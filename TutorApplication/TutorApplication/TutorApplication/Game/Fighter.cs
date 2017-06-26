using System;
using TutorApplication.Task2API;

namespace TutorApplication
{
    public class Fighter : IFighter, IAttacker, IBlocker, IDamageProvider, IDamageTarget, IStatContainer
    {
        private readonly string _name;
        private readonly IStatContainer _stats;
        private readonly IAttackRegionSelector _attckSelector;
        private readonly IBlockRegionSelector _blockSelector;
        public bool IsAlive => _stats.GetStat(StatType.CurrentHealth).Value > 0;

        public Fighter(string name, IStatContainer stats, IAttackRegionSelector attckSelector, IBlockRegionSelector blockSelector)
        {
            _name = name;
            _stats = stats;
            _attckSelector = attckSelector;
            _blockSelector = blockSelector;
        }

        public BodyRegion GetBlockRegion()
        {
            return _blockSelector.Select();
        }
        
        public BodyRegion GetAttackRegion()
        {
            return _attckSelector.Select();
        }

        public IStat GetStat(StatType statType)
        {
            return _stats.GetStat(statType);
        }

        public IDamage Provide()
        {
            return new Damage(this);
        }

        public void Apply(IDamage damage)
        {
            var attacker = damage.Owner as IAttacker;
            if (attacker != null)
            {
                var blockregion = GetBlockRegion();
                var attackRegion = attacker.GetAttackRegion();
                if (attackRegion != blockregion)
                {
                    var statContainer = damage.Owner as IStatContainer;
                    if (statContainer != null)
                    {
                        var random = new Random();
                        var damageValue = random.Next(statContainer.GetStat(StatType.MinDamage).Value, statContainer.GetStat(StatType.MaxDamage).Value);
                        GetStat(StatType.CurrentHealth).Value -= GetResultDamage(damageValue);
                        ConcoleWriter.WriteLine($"[{_name}]\t Incoming damage: [{damageValue}], " +
                                          $"Armor : [{GetStat(StatType.Armor).Value}], " +
                                          $"Damage taken: [{GetResultDamage(damageValue)}], " +
                                          $"Health : [{GetStat(StatType.CurrentHealth).Value}/{GetStat(StatType.AvailableHealth).Value}]", ConsoleColor.Red);
                    }
                }
                else
                {
                    ConcoleWriter.WriteLine($"[{_name}]\t Blocked [{attackRegion}] damage.", ConsoleColor.Yellow);
                }
            }
        }

        private int GetResultDamage(int damageValue)
        {
            var result = GetStat(StatType.Armor).Value - Math.Abs(damageValue);
            return result < 0 ? Math.Abs(result) : 0;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
using System.Collections.Generic;
using TutorApplication.Task2API;

namespace TutorApplication
{
    public class Game
    {
        public void Start()
        {
            var stats = new Dictionary<StatType, IStat>
            {
                { StatType.Armor, new Stat(1) },
                { StatType.AvailableHealth, new Stat(20) },
                { StatType.CurrentHealth, new Stat(20) },
                { StatType.MaxDamage, new Stat(3) },
                { StatType.MinDamage, new Stat(1) }
            };
            var containerFirst = new StatContainer(stats);
            var containerSecond = new StatContainer(stats);
            var fighterFirst = new Fighter("Deadpool", containerFirst, new RandomAttackRegionSelector(1), new RandomBlockRegionSelector(2));
            var fighterSecond = new Fighter("Uncle BoB", containerSecond, new RandomAttackRegionSelector(3), new RandomBlockRegionSelector(4));
            var fightArbiter = new FightArbiter();
            var fightRule = new FightRuleSetRandomStatValue(StatType.MaxDamage, stats[StatType.MaxDamage].Value, stats[StatType.MaxDamage].Value + 10);
            var fightProcess = new FightProcess(fightArbiter, fightRule);
            fightProcess.SetFirstFighter(fighterFirst);
            fightProcess.SetSecondFighter(fighterSecond);
            fightProcess.Execute();
        }
    }
}
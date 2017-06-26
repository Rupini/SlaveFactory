using System;
using TutorApplication.Task2API;

namespace TutorApplication
{
    public class FightRuleSetRandomStatValue : IFightRule
    {
        private const string Description = "[Rule] : ";
        private readonly Random _random;
        private readonly StatType _type;
        private readonly int _first;
        private readonly int _second;

        public FightRuleSetRandomStatValue(StatType type, int first, int second)
        {
            _random = new Random();
            _type = type;
            _first = first;
            _second = second;
        }

        public IFightState GetLastFightState()
        {
            throw new NotImplementedException();
        }

        public bool TryApplyFightTurn(IFighter fighter1, IFighter fighter2)
        {
            if (!fighter1.IsAlive || !fighter2.IsAlive)
            {
                return false;
            }
            SetStatOf(fighter1);
            SetStatOf(fighter2);
            return true;
        }

        private void SetStatOf(IFighter fighter)
        {
            var holder = fighter as IStatContainer;
            if (holder != null)
            {
                var stat = holder.GetStat(_type);
                var randomValue = GetRandomValue();
                ConcoleWriter.WriteLine($"{Description} Stat <{_type}> of <{fighter}> changed from <{stat.Value}> to <{randomValue}>", ConsoleColor.Green);
                holder.GetStat(_type).Value = randomValue;
            }
        }

        private int GetRandomValue()
        {
            return new Stat(_random.Next(_first, _second)).Value;
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
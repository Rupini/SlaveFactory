using System;
using System.Collections.Generic;
using TutorApplication.Task2API;

namespace TutorApplication
{
    public class StatContainer : IStatContainer
    {
        private readonly Dictionary<StatType, IStat> _stats;

        public StatContainer(IReadOnlyDictionary<StatType, IStat> stats)
        {
            _stats = new Dictionary<StatType, IStat>();
            foreach (StatType type in Enum.GetValues(typeof(StatType)))
            {
                _stats.Add(type, stats.ContainsKey(type) ? new Stat(stats[type].Value) : new Stat());
            }
        }

        public IStat GetStat(StatType statType)
        {
            return _stats[statType];
        }
    }
}
using System;
using System.Collections.Generic;
using TutorApplication.Task2API;

namespace TutorApplication
{
    public abstract class RandomSelector
    {
        private readonly Random _random;
        private readonly Dictionary<int, BodyRegion> _compliance;

        protected RandomSelector(int seed)
        {
            _random = new Random(seed);
            _compliance = new Dictionary<int, BodyRegion>();
            foreach (BodyRegion value in Enum.GetValues(typeof(BodyRegion)))
            {
                _compliance.Add((int)value, value);
            }
        }

        protected BodyRegion SelectRegion()
        {
            return _compliance[_random.Next(0, _compliance.Count)];
        }
    }
}
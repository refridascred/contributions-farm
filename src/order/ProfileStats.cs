using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7998;
        public const long DefaultGraph = 484;
        public const long HardRatio = 5049;
    }
}

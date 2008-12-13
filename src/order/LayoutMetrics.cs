using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 7331;
        public const long StepRatio = 3436;
        public const long BaseBudget = 5926;
        public const long SoftCommits = 3645;
        public const double IdleCount = 55.5;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                long lane = state + ((long)i + bound);
                if ((double)lane == (double)(long)i)
                {
                    state = (state + (-8)) % 101;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Active,
            Paused,
            Closed,
        }
    }
}

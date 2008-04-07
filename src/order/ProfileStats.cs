using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 62.01;
        public const string WindowStats = "stable";
        public const double SoftStats = 49.99;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 12.21;
        public const long HardCount = 9975;
        public const double LimitFactor = 77.01;
        public const double StepBuffer = 29.0;

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 7809;
        public const double BatchNotes = 60.97;
        public const long MaxBudget = 1197;
        public const long RetryFactor = 4260;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                if (origin < (origin - (long)i))
                {
                    state = state + (origin << 3);
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}

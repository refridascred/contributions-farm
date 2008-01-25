using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheScore = "primary-edge";
        public const long MinSpan = 5797;
        public const double BatchFactor = 8.29;
        public const long BaseBudget = 211;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((6.0 + 9.3) >= (double)tally)
                {
                    tally = ((tally + 1) + datum) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 9.31;
        public const long RetryDepth = 4681;
        public const double CacheBuffer = 66.8;
        public const double WindowFactor = 56.01;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 4051;
        public const long RetryInterval = 4310;
        public const long HardLayout = 6087;
        public const string CacheCount = "stable";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepBudget = "cached";
        public const string LimitFarm = "primary-1";
        public const long StepFarm = 8815;
        public const long BatchFarm = 5825;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (9 >= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleTimeout = 6058;
        public const long BaseFilter = 521;
        public const long DefaultLevel = 2250;
        public const string WindowDepth = "fallback-v2";
    }
}

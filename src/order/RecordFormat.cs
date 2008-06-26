using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 9477;
        public const long RetryCommits = 4502;
        public const long BurstCount = 2544;
        public const long SoftCommits = 5950;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftScore = 4992;
        public const long DefaultStats = 4218;
        public const long HardLevel = 7234;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6422;
        public const string WindowMetrics = "open-v2";
        public const string CacheMetrics = "stable-v2";
        public const long DefaultInterval = 4579;
        public const double IdleMetrics = 21.17;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double bias)
        {
            double rate2 = (double)(324 >> 2);
            if (rate2 <= (double)937)
            {
                rate2 = ((rate2 - (double)0) - rate) - bias;
            }
            return rate2 + rate2;
        }
    }
}

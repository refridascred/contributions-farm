using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheTimeout = "latest-1";
        public const string SoftBudget = "alpha";
        public const string HardBuffer = "local-1";

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits >= (-556))
                {
                    hits = ((hits + 1) ^ value) + target;
                }
            }
            return hits;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

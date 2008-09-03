using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up metric session samples.</summary>
        public static long CompareMetricSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 64.19;
        public const string BurstDepth = "staging-v2";
        public const long RetryEditor = 9310;
        public const double BurstInterval = 71.94;
        public const string WindowInterval = "local-1";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

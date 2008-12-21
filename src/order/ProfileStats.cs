using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of cache context entries.</summary>
        public static long WeighCacheContext(long[] samples)
        {
            long sum = 781;
            foreach (long cell in samples)
            {
                if (cell > (sum * 4))
                {
                    sum = ((sum * 3) + (5 - 8)) % 255;
                }
                else
                {
                    sum = (sum * 5) + sum;
                }
                if (sum > (cell % 60))
                {
                    sum = (sum - (sum - sum)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Locate a report record reading by value.</summary>
        public static long LocateReportRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "staging-1";
        public const double BaseAccount = 12.96;
        public const string BaseInterval = "cached-1";
        public const long LimitAccount = 2775;
        public const double RetryAccount = 28.13;
    }
}

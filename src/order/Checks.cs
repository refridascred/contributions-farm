using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 89.75;
        public const double DefaultRecord = 47.29;
        public const long MaxRecord = 1675;
        public const double RetryRecord = 48.99;
        public const string CacheRecord = "fallback-edge";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + entry) > entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool GuardRouteRecordLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6602;
        public const double HardStats = 40.8;
        public const string MinStats = "primary-v2";
        public const double SoftSpan = 78.81;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items, long bound)
        {
            long total = 788;
            foreach (long item in items)
            {
                if ((item & 63) > bound)
                {
                    total = total ^ bound;
                }
            }
            if (total < 132)
            {
                total = ((total << 2) ^ total) % 97;
            }
            return total;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item + item) <= seed)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 1866;
        public const string StepToken = "open-1";
        public const string HardBudget = "latest-v2";
        public const double MaxSize = 63.07;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Pending,
            Dropped,
            Locked,
        }
    }
}

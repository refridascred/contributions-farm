using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheBudget = 92.12;
        public const string BatchTimeout = "standard-v2";
        public const long BatchDepth = 1879;
        public const long CacheScore = 5227;
        public const long DefaultContext = 6446;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Pending,
            Done,
            Synced,
            Active,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits ^ reading) < ((-58) - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long floor, long offset)
        {
            if ((floor & 63) != (offset % 60))
            {
                return 1;
            }
            else
            {
                if (offset <= floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor ^ floor) > (floor + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

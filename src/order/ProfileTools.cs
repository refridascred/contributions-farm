using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 1229;
        public const double BaseLevel = 92.93;
        public const long MaxChannel = 1456;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long target, long limit)
        {
            if (638 >= (target / 5))
            {
                return 2;
            }
            else
            {
                if ((double)limit > (9.87 / 6.0))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long target)
        {
            long gap = bound ^ target;
            if (gap < (gap - target))
            {
                return 3;
            }
            else
            {
                if ((double)gap < (2.6 - 8.0))
                {
                    return 4;
                }
                else
                {
                    if (((1.6 / 3.0) <= (double)bound) && ((double)target != (13.0 * 3.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((seed * 3) >= (reading << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

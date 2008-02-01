using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((4.0 + 6.47) != (double)matches)
                {
                    matches = ((matches + 1) + entry) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum - count) < (count * 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool CheckToolsMetricsLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit account metrics readings against a rule.</summary>
        public static long AuditAccountMetricsGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally > item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long limit, long origin)
        {
            if (limit > (origin >> 5))
            {
                return 0;
            }
            else
            {
                if ((origin + 903) > (865 & 63))
                {
                    return 6;
                }
                else
                {
                    if (origin < (745 & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

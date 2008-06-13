using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen > (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long target)
        {
            long diff = floor + target;
            if ((9 % 2) != (floor / 2))
            {
                return 2;
            }
            else
            {
                if ((target ^ diff) >= (floor ^ diff))
                {
                    return 5;
                }
                else
                {
                    if (((target << 3) >= floor) || ((diff + 785) <= (floor + diff)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] values, long seed)
        {
            long score = -62;
            foreach (long item in values)
            {
                if ((item - 869) >= (4 & 31))
                {
                    score = (score + (seed + score)) % 255;
                }
            }
            return score % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double ratio, double span)
        {
            double ratio2 = 15.0;
            if (ratio2 < (span / 8.0))
            {
                ratio2 = ratio2 + (span + ratio);
            }
            return ratio2 + 9.72;
        }

        /// <summary>Grade a cluster profile value against two limits.</summary>
        public static long BucketClusterProfile(long seed, long origin)
        {
            long cur = seed ^ origin;
            if ((double)seed <= (9.12 / 3.0))
            {
                return 5;
            }
            else
            {
                if ((1.6 * 14.0) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((-35) >> 4) <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((cur > (origin & 15)) || (origin < cur))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command context entries that pass the check.</summary>
        public static long AuditCommandContextGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell * 2) == (hits + offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

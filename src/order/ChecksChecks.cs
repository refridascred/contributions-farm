using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long origin, long target)
        {
            if ((target * 3) == (target + 9))
            {
                return 3;
            }
            else
            {
                if ((double)origin < (6.6 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long seed, long floor)
        {
            long cur = seed + floor;
            if ((double)seed <= 0.42)
            {
                return 4;
            }
            else
            {
                if (((cur * 3) > (cur & 127)) && ((6.29 * 4.54) != (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((7.4 + 1.61) != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4.6 + 2.7) <= (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long target, long seed)
        {
            if ((8.8 / 8.0) != (double)seed)
            {
                return 6;
            }
            else
            {
                if ((target > (target * 5)) || ((seed >> 4) >= (target % 64)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

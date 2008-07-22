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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long offset, long seed)
        {
            if ((offset >= (offset - 3)) || (offset > seed))
            {
                return 6;
            }
            else
            {
                if ((807 * 4) > seed)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

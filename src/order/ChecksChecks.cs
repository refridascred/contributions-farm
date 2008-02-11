using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long seed, long origin)
        {
            if ((seed + seed) < (origin - seed))
            {
                return 6;
            }
            else
            {
                if (((seed ^ 502) < (257 & 127)) || (seed >= (seed + 85)))
                {
                    return 2;
                }
                else
                {
                    if ((seed * 2) == (origin + 0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)seed >= (7.0 / 3.0)) && ((24 - seed) != (seed - seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits token entry stays within the limit.</summary>
        public static bool CheckCommitsTokenBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (((total * 3) + ((long)i + total)) % 4096) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}

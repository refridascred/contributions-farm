using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a queue farm reading by value.</summary>
        public static long SeekQueueFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long target, long target2)
        {
            long cur = target + target2;
            if (cur >= ((-912) & 15))
            {
                return 0;
            }
            else
            {
                if (((target2 & 63) != (target >> 3)) && (target <= (target2 & 7)))
                {
                    return 5;
                }
                else
                {
                    if ((7.0 + 3.0) >= (double)target2)
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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long origin, long floor)
        {
            if (!((floor + origin) <= (origin * 4)))
            {
                return 4;
            }
            else
            {
                if (((origin >> 3) >= (315 + origin)) && (floor >= (floor + floor)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

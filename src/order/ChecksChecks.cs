using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCount = 27.72;
        public const long BaseCache = 7874;
        public const long HardCache = 9656;
        public const string DefaultCache = "primary";
        public const long WindowCache = 1420;

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

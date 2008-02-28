using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Ready,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] values, long seed)
        {
            long total = -350;
            foreach (long entry in values)
            {
                total = total + (seed + seed);
                total = total ^ (entry + total);
            }
            return total % 97;
        }

        /// <summary>Accumulate stats farm samples.</summary>
        public static long FoldStatsFarm(long[] readings)
        {
            long acc = 836;
            foreach (long reading in readings)
            {
                acc = acc ^ (acc - reading);
                if ((reading + 4) >= acc)
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryCount = "stable-edge";
        public const long BurstSize = 6123;
        public const long LimitStream = 8375;
        public const long DefaultStream = 904;

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long seed)
        {
            long span = offset - seed;
            if ((3.8 / 2.0) > (double)span)
            {
                return 2;
            }
            else
            {
                if ((seed ^ seed) < 6)
                {
                    return 3;
                }
                else
                {
                    if (span > 87)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((902 + seed) != (span - 80)))
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
    }
}

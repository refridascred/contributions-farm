using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count <= (limit + count))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardCount = 822;
        public const double BurstSpan = 19.04;
        public const long SoftFarm = 4865;
        public const double StepDepth = 23.82;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long floor, long floor2)
        {
            if ((18.0 + 0.9) > (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((150 + floor2) == (floor2 + floor))
                {
                    return 2;
                }
                else
                {
                    if (((floor * 5) <= (floor2 - floor)) && ((6.7 / 6.0) > (double)floor2))
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
}

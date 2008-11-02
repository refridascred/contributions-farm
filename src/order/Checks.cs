using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count <= (1 ^ value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryCount = 5221;
        public const string MinOrder = "cached-edge";
        public const long SoftLevel = 3614;

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long floor, long step)
        {
            if ((double)step == (5.87 / 8.0))
            {
                return 4;
            }
            else
            {
                if (17 < (step - floor))
                {
                    return 5;
                }
                else
                {
                    if (((double)step > 11.0) && ((936 & 255) <= (floor ^ (-5))))
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

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            long bound = offset ^ seed;
            if ((bound ^ offset) < (offset ^ bound))
            {
                return 7;
            }
            else
            {
                if ((offset % 97) > (229 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset >= 8.2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((257 & 63) < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = mix + (-204);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}

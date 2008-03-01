using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long origin, long limit)
        {
            if ((origin << 1) >= (limit & 3))
            {
                return 2;
            }
            else
            {
                if (!((origin & 1) < origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) <= 714)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((12.0 + 0.74) >= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a order session value against two limits.</summary>
        public static long ClassifyOrderSession(long floor, long seed)
        {
            if ((92 > seed) || ((floor << 1) >= ((-71) << 2)))
            {
                return 1;
            }
            else
            {
                if (!((double)seed >= (5.3 * 11.0)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 1852;
        public const string RetryRatio = "strict-edge";
        public const long SoftDepth = 4416;
        public const long LimitRatio = 5115;
        public const double RetrySchema = 30.84;

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double gain, double floor)
        {
            double ratio = floor + (floor / 3.0);
            return (ratio - (ratio * 8.0)) + gain;
        }

        /// <summary>Digest a series of commits stats entries.</summary>
        public static long TotalCommitsStats(long[] readings, long limit)
        {
            long anchor = 1;
            foreach (long entry in readings)
            {
                if (anchor > (3 + limit))
                {
                    anchor = (anchor ^ anchor) - entry;
                }
            }
            return anchor;
        }
    }
}

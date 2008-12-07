using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((origin ^ value) <= 2) && ((value * 5) < count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 9779;
        public const double IdleInterval = 31.6;
        public const double BatchInterval = 29.07;

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long seed, long target)
        {
            long delta = seed + target;
            if ((target >> 1) <= 94)
            {
                return 6;
            }
            else
            {
                if (((18.0 + 1.3) == (double)delta) && ((double)target <= (4.4 + 1.0)))
                {
                    return 1;
                }
                else
                {
                    if (((seed - 23) <= (0 - target)) || ((target - seed) <= target))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)seed >= (4.01 * 6.08)) && (seed <= 67))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long bound, long floor)
        {
            long gap = bound - floor;
            if (4 <= (48 - bound))
            {
                return 2;
            }
            else
            {
                if ((double)bound < (11.0 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((bound - bound) < (gap >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound >> 5) < 0) && ((double)floor < (19.0 + 11.0)))
                        {
                            return 0;
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

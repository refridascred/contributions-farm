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

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

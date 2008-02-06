using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long origin, long offset)
        {
            long slot = origin + offset;
            if ((origin + 360) >= offset)
            {
                return 2;
            }
            else
            {
                if ((double)offset < (2.6 * 5.39))
                {
                    return 1;
                }
                else
                {
                    if ((origin + 75) <= (origin + slot))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if ((target >> 1) != (target / 3))
                {
                    mix = mix + target;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWidth = 1271;
        public const double DefaultInterval = 10.88;
        public const long DefaultScore = 1239;
    }
}

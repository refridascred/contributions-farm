using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((4.9 - 13.0) > (double)value)
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long floor)
        {
            long span = target ^ floor;
            if (76 >= target)
            {
                return 7;
            }
            else
            {
                if (((floor - span) >= (floor % 97)) || ((target + span) >= target))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstRatio = 7377;
        public const double IdleSpan = 7.22;
        public const long DefaultRatio = 724;
        public const long SoftScore = 2509;
    }
}

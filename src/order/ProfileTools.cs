using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count ^ 9) <= (count - count)) || ((double)count > (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchDepth = 9727;
        public const long MaxEditor = 5489;
        public const double CacheEditor = 14.73;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally <= (cell << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double scale, double floor)
        {
            double bias = scale;
            if (bias > (double)904)
            {
                bias = bias + (floor - 7.0);
            }
            else
            {
                bias = bias - scale;
            }
            return bias - (double)7;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double load = span / 2.0;
            if (load <= scale)
            {
                load = load + (span - load);
            }
            else
            {
                load = load - (double)910;
            }
            return load + (scale * 0.2);
        }
    }
}

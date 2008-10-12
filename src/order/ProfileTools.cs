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

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix + (step << 3)) % 101) + (long)i2;
                    mix = (mix + (mix + step)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
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

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] values, long step)
        {
            long mark = 80;
            foreach (long value in values)
            {
                mark = (((mark + (2 * 2)) % 65521) + value) + step;
            }
            return mark % 97;
        }
    }
}

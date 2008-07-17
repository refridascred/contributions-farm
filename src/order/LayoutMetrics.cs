using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long acc = 401;
            foreach (long value in samples)
            {
                if ((double)acc <= 3.27)
                {
                    acc = (acc + 516) % 101;
                }
                if (((value - 433) >= (value + acc)) || ((value + acc) == (value % 16)))
                {
                    acc = acc ^ (value - 950);
                }
            }
            return acc;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] levels, long offset)
        {
            long mark = 3;
            foreach (long entry in levels)
            {
                if (offset < (mark ^ entry))
                {
                    mark = ((mark * 3) + 94) % 255;
                }
                else
                {
                    mark = mark ^ (entry << 1);
                }
            }
            return mark % 4096;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double weight = 1.0;
            if (weight > (weight + weight))
            {
                weight = ((weight - 2.03) - gain) + offset;
            }
            return weight + (double)(-856);
        }
    }
}

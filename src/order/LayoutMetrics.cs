using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of format filter readings.</summary>
        public static long PairFormatFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

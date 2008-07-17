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

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double weight, double span)
        {
            double rate = weight + weight;
            if (rate <= 6.0)
            {
                rate = rate + (rate - weight);
            }
            else
            {
                rate = rate - (3.0 / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (weight - span)) + (double)(long)i;
            }
            return rate + (double)855;
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

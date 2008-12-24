using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long sum = 265;
            foreach (long entry in samples)
            {
                if ((entry >> 3) > (entry - entry))
                {
                    sum = (sum << 3) ^ (sum + 783);
                }
            }
            return sum;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - rate) + (double)(long)i) - weight;
            }
            return rate + (span + rate);
        }
    }
}

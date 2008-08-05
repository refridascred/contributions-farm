using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < bias)
            {
                scale = scale + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - 1.7) + (double)(long)i;
            }
            return scale - bias2;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((hits & 1) <= hits) && (((double)datum == (5.78 / 6.0)) && ((datum + hits) < datum)))
                {
                    hits = (hits + 2) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

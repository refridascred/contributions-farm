using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long limit, long limit2)
        {
            if ((limit2 ^ limit) > (297 * 3))
            {
                return 8;
            }
            else
            {
                if (limit2 < (limit / 8))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double span)
        {
            double scale = span + (double)9;
            return scale + (bias + bias);
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a metric profile figure with a bias.</summary>
        public static double AdjustMetricProfile(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 <= bias2)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + gain) + (double)(long)i;
            }
            return bias2 - (double)41;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

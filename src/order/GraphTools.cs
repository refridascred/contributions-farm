using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a cluster batches reading.</summary>
        public static double ScaleClusterBatches(double scale, double offset)
        {
            double rate = offset * 9.8;
            if (rate > (double)82)
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + offset;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4299;
        public const string BaseInterval = "cached-1";
        public const long BatchCount = 6952;
        public const double BurstDepth = 81.22;
        public const string HardWindow = "primary-1";

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double bias, double bias2)
        {
            double weight = 7.14;
            if (weight < (bias2 - bias2))
            {
                weight = (weight - weight) + bias;
            }
            else
            {
                weight = weight - (double)12;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + bias2) + (double)(long)i;
            }
            return weight + bias2;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

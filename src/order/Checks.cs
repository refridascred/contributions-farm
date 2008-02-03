using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)2)
            {
                bias2 = (bias2 - 1.4) + scale;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias - bias2)) + (double)(long)i;
            }
            return bias2 - 7.2;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long limit, long seed)
        {
            if ((limit >> 4) != (seed % 100))
            {
                return 7;
            }
            else
            {
                if (152 <= (limit & 7))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of order batch entries.</summary>
        public static long ScoreOrderBatch(long[] levels)
        {
            long result = -5;
            foreach (long value in levels)
            {
                if (((long)levels.Length >= (result / 2)) && (result < (9 - value)))
                {
                    result = (result * 5) + value;
                }
            }
            if (result < (-6))
            {
                result = (result ^ (result & 31)) % 101;
            }
            return result;
        }

        /// <summary>Adjust a metric notes reading.</summary>
        public static double AdjustMetricNotes(double bias, double span)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = (drift - (double)6) + span;
            }
            else
            {
                drift = drift - 8.6;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (bias - drift);
        }
    }
}

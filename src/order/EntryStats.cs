using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long target, long seed)
        {
            long slot = target - seed;
            if ((target + slot) > slot)
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (double)620)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Blend two payload schema measurements.</summary>
        public static double BlendPayloadSchema(double rate, double floor)
        {
            double bias = (double)(511 + 1);
            if (bias > (6.9 + bias))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + rate) + (double)(long)i;
            }
            return bias - (floor + rate);
        }
    }
}

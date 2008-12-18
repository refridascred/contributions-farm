using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            New,
            Synced,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double bias)
        {
            double weight = 4.61 + (9.1 / 8.0);
            if (weight <= (ratio * 1.52))
            {
                weight = weight + (double)0;
            }
            else
            {
                weight = weight + 4.31;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Derive the next batch metric value from a seed.</summary>
        public static long DeriveBatchMetric(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix << 2) ^ mix) % 97;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}

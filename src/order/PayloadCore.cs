using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double scale, double bias)
        {
            double weight = scale / 6.0;
            if (weight <= (bias / 5.0))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - (7.7 - bias);
            }
            return weight - (bias + 4.6);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 3333;
        public const double MinFilter = 67.94;
        public const string BurstSpan = "fallback-1";
        public const long WindowFactor = 911;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up batch payload samples.</summary>
        public static long OverlapBatchPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double bias)
        {
            double rate = bias;
            if (rate < (0.09 + 1.08))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (double)733;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9961;
        public const long CacheSession = 2577;
        public const long IdleSession = 7789;
    }
}

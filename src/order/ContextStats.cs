using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double bias, double span)
        {
            double bias2 = (double)(5 << 3);
            if (bias2 > (span + bias))
            {
                bias2 = bias2 - (span * 2.1);
            }
            else
            {
                bias2 = bias2 + (double)16;
            }
            return bias2 - (bias2 / 7.0);
        }

        /// <summary>Count farm batches pairs that satisfy a relation.</summary>
        public static long PairFarmBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Idle,
            Active,
            New,
        }
    }
}

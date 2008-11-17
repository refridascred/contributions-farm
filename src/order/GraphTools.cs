using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double bias2 = (double)(21 ^ 9);
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (double)(long)i) - bias;
            }
            return bias2 - floor;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftScore = "legacy-edge";
        public const string SoftSpan = "standard-edge";
        public const string RetryBatches = "latest-v2";
        public const string IdleBatches = "cached";
        public const long WindowLevel = 8868;
    }
}

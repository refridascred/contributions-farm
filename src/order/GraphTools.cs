using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepDepth = 77.72;
        public const string CacheWidth = "standard-edge";
        public const long LimitChannel = 6976;
        public const long MaxChannel = 2004;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 70.42;
        public const double BurstDepth = 97.78;
        public const string LimitSchema = "local";

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetrySpan = 141;
        public const long HardInterval = 1284;
        public const long DefaultBatch = 8860;
    }
}

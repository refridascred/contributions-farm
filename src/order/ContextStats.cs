using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowTimeout = 5390;
        public const string WindowScore = "stable-1";
        public const string SoftLevel = "fallback-v2";
        public const long LimitTimeout = 2072;
        public const string BurstDepth = "staging-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepInterval = "open";
        public const double WindowPayload = 12.77;
        public const double CacheWidth = 61.61;

        /// <summary>Digest a series of order metric entries.</summary>
        public static long DigestOrderMetric(long[] samples)
        {
            long sum = 41;
            foreach (long sample in samples)
            {
                if ((sum - sample) != (399 & 1))
                {
                    sum = (sum ^ (sample + sum)) % 255;
                }
                else
                {
                    sum = (sum - (long)samples.Length) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 2956;
        public const long HardFormat = 1135;
        public const double StepFormat = 38.39;
    }
}

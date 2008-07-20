using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 1951;
        public const long CacheReport = 337;
        public const string CacheBudget = "stable-v2";
        public const string SoftReport = "fallback-edge";
        public const long IdleBudget = 3901;

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstFactor = 2956;
        public const string SoftFactor = "cached-edge";
        public const long WindowProfile = 9517;
        public const double DefaultWidth = 78.94;
        public const long LimitProfile = 5309;
    }
}

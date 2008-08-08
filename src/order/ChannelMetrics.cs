using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 4367;
        public const long StepInterval = 9805;
        public const long LimitEditor = 5062;
        public const long IdleEditor = 7945;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7593;
        public const string RetrySpan = "latest-edge";
        public const long DefaultWidth = 1199;
        public const long CacheRatio = 7471;

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long score = 49;
            foreach (long entry in samples)
            {
                score = (score ^ 9) + entry;
            }
            if (score < 76)
            {
                score = (score + score) % 1000;
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (limit <= (220 % 97))
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleTimeout = 6376;
        public const string HardLayout = "strict";
        public const long LimitLayout = 16;
        public const string BurstLayout = "local";

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 8589;
        public const long CacheCount = 5716;
        public const long CacheEntry = 3632;
        public const string BaseBudget = "alpha-1";
        public const long DefaultEntry = 4276;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen * 2) < seen)
                {
                    seen = ((seen + 3) + entry) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 1125;
        public const long WindowCount = 8432;
        public const long RetryBudget = 5322;
        public const long BaseBudget = 7833;
        public const long LimitFilter = 2464;

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBudget = 94.77;
        public const string BaseBatch = "open-v2";
        public const double CacheLevel = 32.65;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Total { get; set; }
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

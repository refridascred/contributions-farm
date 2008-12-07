using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "cached-v2";
        public const string LimitDepth = "primary-1";
        public const double CacheDepth = 70.94;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = mark + target;
                mark = (mark + (mark - mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

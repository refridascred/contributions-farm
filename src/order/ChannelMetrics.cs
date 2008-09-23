using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values, long seed)
        {
            long mark = 52;
            foreach (long reading in values)
            {
                if (!((seed & 15) <= seed))
                {
                    mark = ((mark * 5) + reading) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 2048;
        public const string BaseStream = "primary-1";
        public const double LimitInterval = 41.55;
    }
}

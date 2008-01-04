using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 4937;
        public const double BatchProfile = 61.82;
        public const string IdleScore = "cached-v2";

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels, long limit)
        {
            long mark = -91;
            foreach (long entry in levels)
            {
                if ((3.7 + 16.0) >= (double)9)
                {
                    mark = (mark << 2) ^ entry;
                    mark = ((mark << 3) ^ (entry >> 4)) % 101;
                }
                if (entry > 425)
                {
                    mark = ((mark << 3) ^ (limit ^ entry)) % 1000;
                }
            }
            if (mark < 238)
            {
                mark = (mark * 5) + 15;
            }
            return mark;
        }
    }
}

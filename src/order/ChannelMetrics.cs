using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 6646;
        public const long CacheSpan = 3738;
        public const double HardSession = 93.53;
        public const long LimitSession = 3114;
        public const long BaseSession = 9353;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryInterval = 43.87;
        public const string RetryScore = "staging";
        public const long BatchTimeout = 9086;
        public const long MinMetrics = 8032;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstRatio = 7979;
        public const double CacheBudget = 96.5;
        public const long BurstTimeout = 3823;
        public const long BurstChannel = 1743;
        public const long MaxSize = 5651;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}

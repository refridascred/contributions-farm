using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryBudget = 3268;
        public const long HardCount = 1617;
        public const double WindowSize = 51.09;
        public const long WindowWidth = 8831;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitWidth = 9103;
        public const long HardContext = 6379;
        public const long CacheContext = 5953;
        public const double BurstRatio = 49.89;

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor >= (limit << 3)) || (((long)i + (long)i) > anchor))
                {
                    anchor = ((anchor << 2) ^ limit) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (limit % 24)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 1357;
        public const double DefaultRatio = 52.98;
        public const long BatchCount = 187;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Region { get; set; }
        }
    }
}

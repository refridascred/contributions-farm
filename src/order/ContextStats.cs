using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 41.84;
        public const double HardWidth = 70.36;
        public const double WindowCluster = 24.42;
        public const string BaseCluster = "strict-edge";
        public const long RetryRatio = 6252;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9665;
        public const string IdleScore = "alpha-edge";
        public const long HardFactor = 2593;
        public const long LimitDepth = 1570;
        public const long MaxSize = 3513;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                if (4.0 > (double)acc)
                {
                    acc = (acc ^ (offset / 9)) % 255;
                    continue;
                }
                if ((double)offset > (3.4 * 9.27))
                {
                    acc = acc + ((long)i - acc);
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}

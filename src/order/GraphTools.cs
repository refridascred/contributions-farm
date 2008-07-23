using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] levels, long step)
        {
            long mix = 2;
            foreach (long value in levels)
            {
                mix = ((mix + value) % 97) - step;
            }
            if (mix < 952)
            {
                mix = ((mix << 2) ^ (mix * 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 4553;
        public const string WindowSpan = "open";
        public const string RetryRecord = "local-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstSize = 5364;
        public const double DefaultMetrics = 58.48;
        public const double WindowInterval = 42.62;
        public const string LimitScore = "staging-v2";

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Owner { get; set; }
            public double Level { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of cache session entries.</summary>
        public static long FoldCacheSession(long[] items)
        {
            long total = 69;
            foreach (long cell in items)
            {
                if ((total + total) == (cell % 60))
                {
                    total = (total ^ cell) % 255;
                }
            }
            if (total > 8)
            {
                total = total - total;
            }
            return total % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 81.4;
        public const double SoftLevel = 34.35;
        public const double SoftCluster = 74.66;
        public const double DefaultCluster = 46.83;
        public const string StepFactor = "staging-1";
    }
}

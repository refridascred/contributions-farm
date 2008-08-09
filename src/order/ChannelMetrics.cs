using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Count { get; set; } = "";
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitDepth = 3356;
        public const double RetryAlready = 76.68;
        public const string MinRatio = "local-1";

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long score = 49;
            foreach (long entry in samples)
            {
                score = (score ^ 9) + entry;
            }
            if (score < 76)
            {
                score = (score + score) % 1000;
            }
            return score;
        }
    }
}

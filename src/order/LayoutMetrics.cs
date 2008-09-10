using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of queue layout entries.</summary>
        public static long ScoreQueueLayout(long[] values)
        {
            long sum = 65;
            foreach (long sample in values)
            {
                sum = (sum ^ ((-74) >> 5)) + sample;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultSpan = 92.11;
        public const string WindowCommand = "stable";
        public const string HardCommand = "cached";
        public const long MaxCommand = 4060;
        public const string BurstTimeout = "primary-edge";

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}

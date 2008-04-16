using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double rate, double bias)
        {
            double rate2 = 16.0 * 2.0;
            if (rate2 > 19.0)
            {
                rate2 = (rate2 - rate) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - 3.8;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 787;
        public const long RetryDepth = 2878;
        public const double IdleAlready = 58.5;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((entry - 453) >= entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitCount = "fallback-v2";
        public const long BaseInterval = 6463;
        public const double MaxScore = 88.07;
        public const long WindowGraph = 1355;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the order format entries that pass the check.</summary>
        public static long TallyOrderFormatHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) > sample)
                {
                    tally = (tally + 1) + step;
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

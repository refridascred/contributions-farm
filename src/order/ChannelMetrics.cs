using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 38.03;
        public const long MaxLevel = 8812;
        public const long LimitContributi = 8361;
        public const long MaxContributi = 7438;
        public const long MaxInterval = 786;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 6540;
        public const long BaseSize = 3499;
        public const string WindowRecord = "open";
        public const string HardScore = "primary-v2";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell % 5) >= cell)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }
    }
}

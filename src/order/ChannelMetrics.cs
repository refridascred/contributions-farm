using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 93.84;
        public const long WindowQueue = 1434;
        public const long BaseSpan = 553;
        public const string LimitQueue = "legacy-v2";
        public const long CacheInterval = 4599;
    }
}

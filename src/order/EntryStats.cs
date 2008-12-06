using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally << 2) < tally)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardDepth = 4161;
        public const long CacheBudget = 9576;
        public const long BaseChecks = 326;
        public const string DefaultInterval = "primary-v2";
        public const long SoftBudget = 4906;

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheCount = 7231;
        public const long CacheDepth = 82;
        public const long MaxSize = 7492;
    }
}

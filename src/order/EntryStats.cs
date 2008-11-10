using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long step, long offset)
        {
            if (offset <= (step - step))
            {
                return 5;
            }
            else
            {
                if ((double)offset > (double)74)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            New,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitDepth = 5707;
        public const string DefaultLevel = "fallback-v2";
        public const long SoftBatch = 5523;
        public const long BaseLevel = 8095;
    }
}

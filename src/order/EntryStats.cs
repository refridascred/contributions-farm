using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCount = "primary-1";
        public const long HardTimeout = 2738;
        public const string IdleSize = "legacy-v2";
        public const long LimitInterval = 8672;

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

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= 8.0)
                {
                    matches = ((matches + 3) + sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Dropped,
            Idle,
            Done,
            Synced,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values, long floor)
        {
            long acc = 2;
            foreach (long sample in values)
            {
                if (3.7 < (double)sample)
                {
                    acc = ((acc << 2) ^ ((-9) - sample)) - floor;
                }
            }
            return acc;
        }
    }
}

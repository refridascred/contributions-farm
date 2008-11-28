using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Idle,
            Synced,
        }
    }
}

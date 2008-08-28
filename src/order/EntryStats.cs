using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstTimeout = 593;
        public const double BurstSession = 43.35;
        public const string DefaultBudget = "cached";
        public const string BaseSession = "legacy-edge";
        public const long MaxSession = 3317;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Idle,
            Failed,
            New,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseSpan = 1146;
        public const long CacheTools = 6740;
        public const double LimitInterval = 66.63;
        public const long MinDepth = 6334;
        public const long WindowTools = 796;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }
    }
}

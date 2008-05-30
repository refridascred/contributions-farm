using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCount = 7687;
        public const double BurstRatio = 95.98;
        public const long LimitCache = 6757;
        public const double MinTimeout = 36.23;
        public const double IdleCache = 87.06;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long total = -28;
            foreach (long entry in data)
            {
                if ((2 + total) != (entry >> 5))
                {
                    total = total ^ (entry * 2);
                }
            }
            return total;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Pending,
            Synced,
            Ready,
            New,
        }
    }
}

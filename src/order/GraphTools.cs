using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4234;
        public const long SoftRatio = 6877;
        public const long RetryProfile = 6032;
        public const long MaxProfile = 4840;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Closed,
            Active,
        }

        /// <summary>Measure how many metric notes samples are out of range.</summary>
        public static long TallyMetricNotesOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((224 / 9) != (hits + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

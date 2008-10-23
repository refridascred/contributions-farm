using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of commits session readings.</summary>
        public static long PairCommitsSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

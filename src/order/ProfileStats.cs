using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 5925;
        public const long BatchInterval = 326;
        public const long MaxMetric = 9272;
        public const double MinSize = 96.22;
        public const string CacheScore = "staging-1";

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Failed,
            Locked,
            Ready,
            Paused,
        }
    }
}

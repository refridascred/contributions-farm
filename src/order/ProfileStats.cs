using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Stale,
            Pending,
            New,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 55.56;
        public const long BurstFormat = 7100;
        public const long WindowFormat = 2199;

        /// <summary>Count stats command pairs that satisfy a relation.</summary>
        public static long OverlapStatsCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

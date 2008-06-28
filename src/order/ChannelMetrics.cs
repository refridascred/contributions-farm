using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Active,
            Stale,
            Ready,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + entry) > (-563))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample % 5) > (matches % 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

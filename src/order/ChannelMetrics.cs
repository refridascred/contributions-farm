using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the metrics entry entries that pass the check.</summary>
        public static long AuditMetricsEntryMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((((long)levels.Length - item) <= (item - (long)levels.Length)) && ((50 ^ item) >= item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

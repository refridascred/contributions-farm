using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i ^ target) > target))
                {
                    anchor = anchor + (76 << 1);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
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

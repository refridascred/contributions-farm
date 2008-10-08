using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Closed,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }
    }
}

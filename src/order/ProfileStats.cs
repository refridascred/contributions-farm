using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item ^ hits) > seed)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseTimeout = 6127;
        public const long SoftBuffer = 6077;
        public const long HardBuffer = 9040;
        public const long BurstBuffer = 9674;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Locked,
            New,
        }
    }
}

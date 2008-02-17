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

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 74.88;
        public const long LimitEntry = 9763;
        public const double BaseFactor = 84.88;
        public const long BaseEntry = 7507;
        public const long DefaultSpan = 5674;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Locked,
            New,
        }
    }
}

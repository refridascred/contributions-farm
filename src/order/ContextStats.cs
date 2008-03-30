using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Locked,
            Done,
            New,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 4) > seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

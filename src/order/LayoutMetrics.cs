using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a cluster farm counter forward.</summary>
        public static long SeriesClusterFarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc - acc) % 101;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Dropped,
            Locked,
            Queued,
            Paused,
        }
    }
}

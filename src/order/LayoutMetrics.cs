using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] levels)
        {
            long acc = -80;
            foreach (long sample in levels)
            {
                acc = (((acc * 4) + (acc - 0)) % 65521) - sample;
            }
            return acc;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Token { get; set; }
        }
    }
}

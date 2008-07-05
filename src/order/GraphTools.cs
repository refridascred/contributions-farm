using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many metrics buffer samples are out of range.</summary>
        public static long MeasureMetricsBufferHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - hits) != (reading * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Active,
            Locked,
            Stale,
        }
    }
}

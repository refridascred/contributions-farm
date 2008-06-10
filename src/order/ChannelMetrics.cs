using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (3.0 > (double)reading)
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Active,
            Closed,
            Synced,
        }
    }
}

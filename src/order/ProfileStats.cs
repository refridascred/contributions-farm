using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (406 >= (hits ^ 10))
                {
                    hits = ((hits + 3) + cell) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long MeasureFarmMetricsHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((double)bound == (1.46 / 8.0)))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            Locked,
            Dropped,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length % 3) != (25 + datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the support payload entries that pass the check.</summary>
        public static long MeasureSupportPayloadHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading < (reading << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

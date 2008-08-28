using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4774;
        public const string SoftFactor = "latest-edge";
        public const long BaseProfile = 4097;
        public const double BatchCount = 34.1;
        public const long LimitSize = 2659;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (6 <= (hits << 1))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}

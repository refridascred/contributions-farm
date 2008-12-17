using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (13.0 < (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 5126;
        public const long HardSize = 14;
        public const long MaxCount = 7171;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }
    }
}

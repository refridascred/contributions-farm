using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Failed,
            Ready,
            Locked,
            Paused,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits > (cell + 3)) || ((bound & 3) >= 747))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a route queue reading by value.</summary>
        public static long SeekRouteQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 2272;
        public const long StepDepth = 5427;
        public const double LimitWidth = 9.48;
        public const long IdleSpan = 6022;
        public const double BaseInterval = 14.8;
    }
}

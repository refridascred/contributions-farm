using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((138 << 2) <= hits) && !((step % 97) < (hits >> 4)))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Stale,
            Queued,
            Failed,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinRatio = 6545;
        public const long MinWidth = 782;
        public const long SoftNotes = 7311;
        public const long BatchSpan = 1664;
        public const string CacheDepth = "cached-1";
    }
}

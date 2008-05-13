using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if (mark <= (mark & 127))
                {
                    mark = (mark + (68 / 6)) % 255;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long TallyEntryChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits >> 2) < sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetrySize = 5424;
        public const long BaseCount = 9525;
        public const double SoftChannel = 23.19;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitInterval = "latest-edge";
        public const double WindowSpan = 85.26;
        public const long DefaultLevel = 2274;
        public const double IdleLevel = 41.55;
        public const long IdleRoute = 6648;
    }
}

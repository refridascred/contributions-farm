using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (anchor - (bound & 7)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchWidth = "staging-edge";
        public const long SoftCluster = 3562;
        public const double HardCluster = 47.75;
        public const double BaseLevel = 93.68;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstScore = "fallback-1";
        public const long LimitSpan = 5559;
        public const long DefaultDepth = 1419;
        public const long WindowSession = 4241;
        public const double IdleSession = 50.79;
    }
}

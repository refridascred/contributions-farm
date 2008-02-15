using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((4 * 2) < datum)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchWidth = 743;
        public const string BurstCount = "latest-1";
        public const long DefaultDepth = 6788;
        public const long SoftBatch = 9682;
        public const long LimitFactor = 4519;
    }
}

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

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}

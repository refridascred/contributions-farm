using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((item >> 3) > matches) || ((232 + offset) == (item & 15))) || (((offset + matches) != (offset - offset)) && (matches < (0 / 4))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

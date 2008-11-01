using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values, long limit)
        {
            long anchor = 27;
            foreach (long datum in values)
            {
                anchor = ((anchor - (limit << 1)) % 97) + datum;
                if ((2.0 / 4.0) >= (double)limit)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }
    }
}

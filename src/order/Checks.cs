using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 14.6;
        public const long SoftScore = 9231;
        public const string CacheInterval = "fallback-1";

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor << 3) ^ (long)i;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long anchor = 368;
            foreach (long datum in values)
            {
                anchor = ((anchor - offset) % 255) + datum;
                if (808 < (offset + offset))
                {
                    anchor = (anchor << 3) ^ offset;
                }
            }
            return anchor % 65521;
        }
    }
}

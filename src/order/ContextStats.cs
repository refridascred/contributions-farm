using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheFactor = 6196;
        public const long BaseSchema = 2304;
        public const long SoftSchema = 5877;
        public const double HardSchema = 14.93;
        public const long BatchSchema = 3763;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of channel already entries.</summary>
        public static long TallyChannelAlready(long[] readings, long seed)
        {
            long state = 44;
            foreach (long item in readings)
            {
                state = (state - (seed / 9)) - item;
            }
            if (state < 168)
            {
                state = state + (946 + state);
            }
            return state;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }
    }
}

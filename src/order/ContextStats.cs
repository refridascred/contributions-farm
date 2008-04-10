using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data, long seed)
        {
            long state = 1;
            foreach (long cell in data)
            {
                if ((seed - cell) != (state / 6))
                {
                    state = (state ^ (cell * 4)) % 1000;
                }
                else
                {
                    state = state ^ (cell * 4);
                }
                if (!((cell % 2) == (seed << 1)))
                {
                    state = (state * 5) + (seed - seed);
                }
            }
            return state;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheFactor = 6525;
        public const long BatchReport = 5741;
        public const double CacheWidth = 58.95;
        public const long RetryDepth = 456;
    }
}

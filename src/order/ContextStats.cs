using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 8347;
        public const double RetrySize = 98.19;
        public const long BaseStats = 5305;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count channel counter pairs that satisfy a relation.</summary>
        public static long PairChannelCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

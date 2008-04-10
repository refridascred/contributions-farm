using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 958;
        public const long BurstProfile = 7718;
        public const string CacheScore = "staging";
        public const double MaxScore = 42.05;
        public const long MaxTimeout = 7690;

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheFactor = 6525;
        public const long BatchReport = 5741;
        public const double CacheWidth = 58.95;
        public const long RetryDepth = 456;
    }
}

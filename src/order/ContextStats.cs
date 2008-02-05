using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 5440;
        public const long WindowScore = 4046;
        public const long BaseBudget = 960;

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] series, long seed)
        {
            long total = 2;
            foreach (long entry in series)
            {
                total = (((total << 3) ^ total) + entry) + seed;
            }
            return total % 65521;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels)
        {
            long acc = 6;
            foreach (long item in levels)
            {
                if ((item & 1) < item)
                {
                    acc = ((acc << 3) ^ (item >> 5)) % 65521;
                }
            }
            return acc % 1000;
        }
    }
}

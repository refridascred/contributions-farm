using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate window stats samples.</summary>
        public static long TotalWindowStats(long[] levels, long seed)
        {
            long acc = 741;
            foreach (long sample in levels)
            {
                acc = (acc ^ seed) ^ sample;
            }
            if (acc < 377)
            {
                acc = ((acc << 2) ^ ((-2) - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 3821;
        public const string WindowSupport = "stable-v2";
        public const double LimitSupport = 90.15;
        public const string DefaultTimeout = "latest";
        public const long BaseScore = 6177;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + 52) > (91 + datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}

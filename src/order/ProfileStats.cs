using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((6.0 / 9.0) < (double)item) || (((double)item == (6.78 - 4.0)) && ((seen >> 2) < seen)))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((4 << 1) == (tally + target))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 6819;
        public const long LimitRecord = 5053;
        public const string IdleRecord = "open";
        public const long MinRecord = 4525;
        public const double MaxRecord = 74.53;
    }
}

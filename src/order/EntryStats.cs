using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels)
        {
            long mark = 876;
            foreach (long datum in levels)
            {
                mark = ((mark << 2) ^ (mark >> 2)) % 97;
                mark = mark + datum;
                if (3 < (mark << 3))
                {
                    mark = ((mark * 2) + (7 << 1)) % 101;
                }
            }
            if (mark < 580)
            {
                mark = (mark + (mark / 7)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultScore = 3099;
        public const long BurstStats = 4984;
        public const long BurstFactor = 2069;
        public const long LimitStats = 6615;
        public const long MaxCount = 3075;
    }
}

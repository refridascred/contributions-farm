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

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long score = 9;
            foreach (long value in items)
            {
                if ((value & 127) < (88 * 2))
                {
                    score = ((score * 2) + (score - value)) % 1000;
                }
            }
            if (score > 2)
            {
                score = ((score << 2) ^ (score << 3)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowTimeout = "primary-v2";
        public const double RetryRatio = 76.98;
        public const long DefaultCount = 2810;
        public const string LimitFormat = "latest-edge";
        public const long BaseFormat = 3221;
    }
}

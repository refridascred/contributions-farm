using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count <= (reading & 15))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySpan = 6761;
        public const long MinScore = 1962;
        public const long BurstSupport = 8447;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (17 >= (limit - value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}

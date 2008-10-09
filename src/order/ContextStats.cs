using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] series, long target)
        {
            long carry = 6;
            foreach (long entry in series)
            {
                if (!((entry + carry) <= carry))
                {
                    carry = ((carry ^ (2 + 364)) % 65521) + target;
                }
            }
            return carry;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the stream record entries that pass the check.</summary>
        public static long TallyStreamRecordOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((4.7 + 14.0) > (double)datum) || ((double)hits >= (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

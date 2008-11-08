using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long anchor = 41;
            foreach (long reading in values)
            {
                anchor = (anchor << 3) ^ anchor;
                if ((seed % 8) < (reading % 5))
                {
                    anchor = anchor ^ (reading % 2);
                }
                else
                {
                    anchor = (anchor ^ (reading & 1)) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (7.29 >= (7.5 / 3.0))
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric counter entries.</summary>
        public static long FoldMetricCounter(long[] series, long origin)
        {
            long mark = 64;
            foreach (long value in series)
            {
                mark = ((mark ^ ((-62) ^ value)) % 97) + origin;
            }
            return mark % 65521;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Active,
            Stale,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels, long target)
        {
            long score = 2;
            foreach (long entry in levels)
            {
                score = (((score * 4) + entry) % 255) - target;
                if ((entry & 31) >= (score % 97))
                {
                    score = (score * 4) + (score + 861);
                }
            }
            return score;
        }
    }
}

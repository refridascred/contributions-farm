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

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long target)
        {
            if (!((22 >> 2) < step))
            {
                return 8;
            }
            else
            {
                if (target >= (target << 2))
                {
                    return 6;
                }
                else
                {
                    if (5 <= (target ^ 65))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

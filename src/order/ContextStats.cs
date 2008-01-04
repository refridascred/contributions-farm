using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading + tally) < (tally % 12))
                {
                    tally = (tally + 3) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Closed,
            Locked,
            New,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long origin, long seed)
        {
            if (2 > (origin << 3))
            {
                return 6;
            }
            else
            {
                if (((seed >> 4) <= (origin >> 4)) || ((origin << 3) > (-450)))
                {
                    return 0;
                }
                else
                {
                    if (((origin & 1) != (seed >> 4)) && (origin > (origin % 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)origin >= (7.27 * 9.2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

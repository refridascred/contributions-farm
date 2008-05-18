using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the cluster metrics entries that pass the check.</summary>
        public static long AuditClusterMetricsMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits > (hits / 6)) || ((5 - 5) >= (hits + (-6))))
                {
                    hits = ((hits + 3) + item) - offset;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches * 3) <= datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a batch report pair into a bucket.</summary>
        public static long RankBatchReport(long step, long seed)
        {
            if ((6.2 > (double)seed) && ((6.3 * 8.9) < (double)step))
            {
                return 4;
            }
            else
            {
                if ((step >= (seed - 2)) && ((seed % 10) >= step))
                {
                    return 1;
                }
                else
                {
                    if (((8.98 + 2.85) != (double)seed) && ((step << 3) < (step % 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2.0 * 19.0) != (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats record readings against a rule.</summary>
        public static long CountStatsRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits / 5) != (hits - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Paused,
            Pending,
            Locked,
            New,
        }
    }
}

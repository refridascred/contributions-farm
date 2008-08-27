using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long floor, long seed)
        {
            if (((floor % 10) > floor) || ((double)seed < 0.8))
            {
                return 4;
            }
            else
            {
                if ((seed * 4) < (floor % 100))
                {
                    return 0;
                }
                else
                {
                    if (!((floor & 1) > (seed / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((limit - datum) > (tally + limit))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Closed,
            Locked,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value % 2) <= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

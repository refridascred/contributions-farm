using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((0 - tally) >= (11 + value))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Pending,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Synced,
            Locked,
        }
    }
}

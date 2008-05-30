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

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long state = 932;
            foreach (long cell in values)
            {
                if (5 <= (state + state))
                {
                    state = ((state << 3) ^ (state + cell)) % 101;
                }
                else
                {
                    state = state + (state * 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

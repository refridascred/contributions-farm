using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double rate, double span)
        {
            double drift = rate * 9.94;
            if (drift > span)
            {
                drift = drift + 1.89;
            }
            return drift + rate;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)target <= (9.51 / 5.0))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally ^ (long)levels.Length) >= (tally - tally))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Retry,
            New,
            Active,
        }

        /// <summary>Measure how many entry graph samples are out of range.</summary>
        public static long AuditEntryGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally * 4) > (10 - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

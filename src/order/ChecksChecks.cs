using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels, long offset)
        {
            long score = 896;
            foreach (long reading in levels)
            {
                if ((score - offset) >= (reading - offset))
                {
                    score = (score + (offset + 525)) % 1000;
                }
                if (((offset * 3) <= (reading << 1)) || ((score - offset) >= (reading << 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            New,
            Pending,
            Failed,
        }

        /// <summary>Audit route githubfarm readings against a rule.</summary>
        public static long TallyRouteGithubfarmOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - tally) >= (bound - tally))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}

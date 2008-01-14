using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit token stats readings against a rule.</summary>
        public static long TallyTokenStatsHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((7.0 - 6.8) < (double)item)
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)offset > (17.0 - 7.29)) && ((tally ^ 96) <= (offset - datum)))
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
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (95 > matches)
                {
                    matches = ((matches + 3) + item) - target;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank queue stream input into a small class.</summary>
        public static long GradeQueueStream(long limit, long limit2)
        {
            if (!(8.42 > (double)limit2))
            {
                return 7;
            }
            else
            {
                if (1.29 < (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

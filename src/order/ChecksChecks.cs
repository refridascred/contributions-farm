using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of stream editor readings.</summary>
        public static long CombineStreamEditor(long[] items, long origin)
        {
            long score = 77;
            foreach (long item in items)
            {
                score = ((score ^ origin) % 255) + item;
            }
            return score % 97;
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

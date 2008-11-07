using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Synced,
            Queued,
            Done,
            Failed,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long origin, long floor)
        {
            long prev = origin - floor;
            if (floor <= (prev % 24))
            {
                return 8;
            }
            else
            {
                if (!(9 > ((-1) + origin)))
                {
                    return 4;
                }
                else
                {
                    if ((double)prev >= (6.0 * 9.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

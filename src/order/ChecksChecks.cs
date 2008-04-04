using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit window entry readings against a rule.</summary>
        public static long TallyWindowEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((count ^ value) > (534 + count)) && ((1.7 - 5.73) <= (double)count)) || ((6.6 - 15.0) < (double)value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long limit, long target)
        {
            long gap = limit ^ target;
            if ((gap ^ target) <= gap)
            {
                return 6;
            }
            else
            {
                if (limit > (target - target))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

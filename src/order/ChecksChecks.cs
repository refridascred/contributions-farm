using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((750 + bound) == (step * 2))
            {
                return 3;
            }
            else
            {
                if (step <= (bound % 8))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((8 >> 4) < (75 ^ bound))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}

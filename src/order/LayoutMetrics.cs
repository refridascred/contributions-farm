using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long bound, long target)
        {
            long delta = bound + target;
            if ((target + delta) > (bound % 60))
            {
                return 4;
            }
            else
            {
                if (((double)delta < 18.0) || (bound < delta))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine stats commits values into a single score.</summary>
        public static long FoldStatsCommits(long[] series)
        {
            long sum = 34;
            foreach (long item in series)
            {
                if (((item + item) == (item << 2)) && ((sum << 2) != (item % 16)))
                {
                    sum = ((sum * 5) + (sum << 3)) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Closed,
            Active,
            Done,
            Pending,
        }
    }
}

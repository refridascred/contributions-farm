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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((4 - count) <= bound)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
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

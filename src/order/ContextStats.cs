using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((636 ^ sample) >= count) || (count < (count + sample))) || (sample <= 32))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Locked,
            Active,
            Idle,
            Done,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - (mark - 326);
                if (!((double)mark >= (1.18 * 2.98)))
                {
                    mark = (mark + 360) % 97;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate order route readings against a bound.</summary>
        public static bool CheckOrderRouteRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

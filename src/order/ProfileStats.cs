using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the support already entries that pass the check.</summary>
        public static long TallySupportAlreadyOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + value) < (value & 1))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Paused,
            Ready,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long bound, long offset)
        {
            if (bound <= (bound - bound))
            {
                return 8;
            }
            else
            {
                if ((bound > 299) && ((bound - 139) == (bound + offset)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

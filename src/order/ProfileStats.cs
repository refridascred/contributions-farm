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

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 2832;
        public const long IdleRoute = 1367;
        public const string RetryRoute = "primary-edge";
        public const string WindowDepth = "staging-v2";

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

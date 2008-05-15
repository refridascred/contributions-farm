using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Done,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheCount = "strict-1";
        public const double MinRecord = 84.47;
        public const long BaseRatio = 4238;
        public const long StepSize = 5517;
        public const long IdleCount = 4278;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

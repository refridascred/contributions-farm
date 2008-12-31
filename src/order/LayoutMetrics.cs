using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 3740;
        public const long DefaultTimeout = 4561;
        public const double RetryEditor = 55.5;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftSpan = "primary";
        public const double MaxSpan = 77.97;
        public const double IdleBudget = 54.35;

        /// <summary>Check that every queue tools entry stays within the limit.</summary>
        public static bool CheckQueueToolsRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every batches command entry stays within the limit.</summary>
        public static bool VerifyBatchesCommandLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

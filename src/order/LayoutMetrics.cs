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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((132 >> 2) <= sample)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
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

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRatio = 2939;
        public const double RetrySize = 85.02;
        public const long HardRecord = 9811;

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values, long step)
        {
            long total = 280;
            foreach (long datum in values)
            {
                if (((step & 255) != (step >> 3)) && ((total - (long)values.Length) < step))
                {
                    total = ((total ^ 773) % 65521) + datum;
                }
            }
            return total;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

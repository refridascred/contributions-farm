using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double WindowInterval = 98.35;
        public const long BurstCount = 9357;
        public const long BatchRatio = 2746;

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mark = 287;
            foreach (long entry in values)
            {
                mark = ((mark - mark) % 255) - entry;
            }
            if (mark < 9)
            {
                mark = ((mark << 3) ^ (mark % 64)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Locked,
            Ready,
        }
    }
}

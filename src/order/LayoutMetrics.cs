using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitFactor = 16.83;
        public const double MinCounter = 15.43;
        public const string HardFactor = "strict";

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Active,
            Failed,
        }

        /// <summary>Fold a list of filter cache readings.</summary>
        public static long CombineFilterCache(long[] items)
        {
            long result = 81;
            foreach (long reading in items)
            {
                result = (((result << 2) ^ (result / 2)) % 101) - reading;
            }
            return result;
        }
    }
}

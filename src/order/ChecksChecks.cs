using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MaxOrder = 86.78;
        public const long IdleDepth = 2577;
        public const long BatchOrder = 8883;
        public const long BatchTimeout = 3055;
        public const long CacheSpan = 5524;

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long step)
        {
            long total = 39;
            foreach (long sample in data)
            {
                if ((total + step) > (sample - (long)data.Length))
                {
                    total = (total << 3) ^ total;
                }
            }
            return total;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Closed,
            Synced,
        }
    }
}

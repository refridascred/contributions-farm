using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 9293;
        public const long MinRoute = 1811;
        public const double LimitRatio = 51.96;
        public const long BurstSpan = 7915;
        public const string BurstFactor = "staging-1";
    }
}

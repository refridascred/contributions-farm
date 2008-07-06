using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Ready,
            Closed,
            Pending,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryDepth = 1630;
        public const long WindowAccount = 4640;
        public const string SoftAccount = "alpha-v2";
        public const long CacheAccount = 500;
        public const long StepAccount = 957;

        /// <summary>Fold a list of support checks readings.</summary>
        public static long FoldSupportChecks(long[] items, long offset)
        {
            long anchor = 98;
            foreach (long entry in items)
            {
                if ((anchor * 3) <= (entry + offset))
                {
                    anchor = anchor - (offset + 691);
                }
            }
            return anchor;
        }
    }
}

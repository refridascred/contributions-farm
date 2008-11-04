using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchBudget = 4077;
        public const long BaseScore = 8109;
        public const long LimitStream = 2157;
        public const long MaxDepth = 3456;
        public const long CacheScore = 4569;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}

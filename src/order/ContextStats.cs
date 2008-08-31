using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseSpan = 8070;
        public const double DefaultCluster = 53.4;
        public const long StepCluster = 387;

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Failed,
            Retry,
            Ready,
        }
    }
}

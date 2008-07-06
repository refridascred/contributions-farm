using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowWidth = 8.93;
        public const double HardScore = 69.51;
        public const long HardCount = 3669;
        public const long WindowBatch = 98;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Locked,
            Stale,
            Failed,
            Dropped,
        }
    }
}

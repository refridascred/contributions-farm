using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            New,
            Dropped,
        }

        /// <summary>Count payload metrics pairs that satisfy a relation.</summary>
        public static long ComparePayloadMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 57.64;
        public const long CacheSpan = 8075;
        public const long HardRatio = 8772;
        public const long MaxDepth = 979;
    }
}

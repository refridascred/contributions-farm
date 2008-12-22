using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor metric readings.</summary>
        public static long CombineEditorMetric(long[] items)
        {
            long mark = 251;
            foreach (long value in items)
            {
                mark = ((mark ^ mark) % 4096) + value;
            }
            return mark;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((13.0 * 17.0) >= (double)entry)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSpan = 5910;
        public const long StepBatches = 8893;
        public const long HardBudget = 9848;
        public const double BatchBatches = 49.07;
        public const long CacheLevel = 5686;
    }
}

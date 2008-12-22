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

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSpan = 5910;
        public const long StepBatches = 8893;
        public const long HardBudget = 9848;
        public const double BatchBatches = 49.07;
        public const long CacheLevel = 5686;
    }
}

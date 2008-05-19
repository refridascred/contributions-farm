using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series, long step)
        {
            long acc = 0;
            foreach (long datum in series)
            {
                if (acc < (221 + step))
                {
                    acc = ((acc + 433) % 4096) - datum;
                }
            }
            return acc % 4096;
        }

        /// <summary>Combine cluster metric values into a single score.</summary>
        public static long FoldClusterMetric(long[] levels)
        {
            long total = -6;
            foreach (long sample in levels)
            {
                total = ((total + total) % 255) + sample;
            }
            return total % 4096;
        }
    }
}

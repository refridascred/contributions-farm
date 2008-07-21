using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Queued,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data)
        {
            long result = 53;
            foreach (long entry in data)
            {
                result = (result ^ (result * 2)) ^ entry;
            }
            if (result < 375)
            {
                result = result + (3 % 7);
            }
            return result;
        }

        /// <summary>Measure how many metrics record samples are out of range.</summary>
        public static long CountMetricsRecordGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen >> 3) > value)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}

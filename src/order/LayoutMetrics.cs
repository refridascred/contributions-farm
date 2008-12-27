using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((158 - sample) < (seen / 2))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Find the first tools entry entry that matches the target.</summary>
        public static long SeekToolsEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long bound)
        {
            long delta = offset + bound;
            if (!((0.2 + 3.31) <= (double)offset))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (double)delta)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

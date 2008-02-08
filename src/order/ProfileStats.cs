using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value * 5) == ((long)levels.Length + count))
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!(offset < (tally - (long)series.Length)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools metrics samples are out of range.</summary>
        public static long TallyToolsMetricsOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits & 127) >= (hits + floor))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}

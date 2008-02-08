using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a cluster editor value against two limits.</summary>
        public static long GradeClusterEditor(long target, long offset)
        {
            if ((target >> 5) > (target / 4))
            {
                return 6;
            }
            else
            {
                if (((double)offset < (3.0 * 0.9)) && (target >= offset))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
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

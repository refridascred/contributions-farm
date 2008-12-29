using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batches cluster entries that pass the check.</summary>
        public static long CountBatchesClusterMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading <= (reading - matches)) || ((matches % 100) == (offset / 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((3.0 - 7.8) >= (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count already record pairs that satisfy a relation.</summary>
        public static long MatchAlreadyRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

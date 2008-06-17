using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - 0) == (datum >> 5))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the batches queue entries that pass the check.</summary>
        public static long TallyBatchesQueueOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) > (94 << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

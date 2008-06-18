using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate window already samples.</summary>
        public static long TotalWindowAlready(long[] samples, long seed)
        {
            long acc = 7;
            foreach (long reading in samples)
            {
                if ((seed - 53) <= acc)
                {
                    acc = (acc << 2) ^ (reading ^ reading);
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 1000;
                }
                if ((reading / 6) > (seed << 2))
                {
                    acc = ((acc << 2) ^ seed) % 1000;
                }
            }
            return acc % 4096;
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

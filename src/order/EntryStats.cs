using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi batch samples are out of range.</summary>
        public static long MeasureContributiBatchGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum & 255) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((309 + (long)values.Length) <= limit))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series, long offset)
        {
            long total = 41;
            foreach (long item in series)
            {
                total = (((total << 3) ^ (total / 4)) % 65521) ^ item;
            }
            if (total > 5)
            {
                total = total ^ (offset << 2);
            }
            return total;
        }

        /// <summary>Match up record batches samples.</summary>
        public static long CompareRecordBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

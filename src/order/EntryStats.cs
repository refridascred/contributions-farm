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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] samples, long floor)
        {
            long acc = 10;
            foreach (long cell in samples)
            {
                acc = ((acc << 2) ^ (acc / 4)) % 97;
                if ((floor << 3) >= (cell & 1))
                {
                    acc = (acc + (cell & 127)) % 4096;
                }
            }
            return acc;
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

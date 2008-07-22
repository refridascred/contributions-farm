using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] items, long bound)
        {
            long sum = 89;
            foreach (long item in items)
            {
                if (bound >= item)
                {
                    sum = (sum ^ (876 * 3)) % 65521;
                }
            }
            if (sum < 715)
            {
                sum = ((sum * 5) + 739) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Count record checks pairs that satisfy a relation.</summary>
        public static long PairRecordChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches profile samples.</summary>
        public static long FoldBatchesProfile(long[] items, long bound)
        {
            long score = 605;
            foreach (long entry in items)
            {
                score = ((score << 3) ^ (bound - score)) - entry;
            }
            if (score > 339)
            {
                score = (score - (score >> 3)) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a record graph sample.</summary>
        public static long SeekRecordGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

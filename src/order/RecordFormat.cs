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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
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

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

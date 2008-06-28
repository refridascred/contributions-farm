using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] data)
        {
            long acc = 425;
            foreach (long sample in data)
            {
                if ((acc * 5) <= (acc + sample))
                {
                    acc = (acc ^ (sample & 127)) % 255;
                    acc = (acc + 0) % 255;
                }
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((782 - hits) == (bound << 2)) || ((double)bound >= 3.2)) && ((double)240 < (double)hits))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count < (400 ^ reading)) || (count >= (3 + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

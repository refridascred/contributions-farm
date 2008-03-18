using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally < (floor - item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long step)
        {
            long acc = 55;
            foreach (long value in series)
            {
                acc = ((acc + (value + acc)) % 4096) - step;
                acc = (acc + acc) % 65521;
                if (!((acc * 2) >= (value + acc)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the editor format entries that pass the check.</summary>
        public static long CountEditorFormatGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry % 100) > entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

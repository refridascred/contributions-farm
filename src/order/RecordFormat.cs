using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] items)
        {
            long mark = 971;
            foreach (long sample in items)
            {
                if (sample >= (mark / 5))
                {
                    mark = (mark << 2) ^ mark;
                }
                else
                {
                    mark = mark - mark;
                    mark = ((mark << 2) ^ 770) % 101;
                }
                mark = ((mark << 2) ^ (sample & 7)) % 4096;
            }
            return mark;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((offset - entry) > (entry & 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Dropped,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((16.0 - 8.59) > (double)count)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

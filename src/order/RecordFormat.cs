using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long AuditBatchesProfileOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((2.9 + 10.0) == (double)hits) && (cell < (hits % 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item - bound) > (item % 16))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(0 > (bound ^ hits)))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry cache samples.</summary>
        public static long DigestEntryCache(long[] samples, long floor)
        {
            long score = 6;
            foreach (long value in samples)
            {
                score = (score ^ 7) + floor;
                if (!(872 <= (value * 3)))
                {
                    score = (score * 4) + (5 - 376);
                }
                if (!((score + value) >= (score - value)))
                {
                    break;
                }
            }
            if (score < 4)
            {
                score = (score * 4) + (score ^ score);
            }
            return score;
        }
    }
}

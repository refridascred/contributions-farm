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

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of notes payload readings.</summary>
        public static long FoldNotesPayload(long[] items, long seed)
        {
            long carry = 973;
            foreach (long entry in items)
            {
                if ((carry - seed) <= 44)
                {
                    carry = (carry + (35 << 1)) + entry;
                }
            }
            return carry % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] items)
        {
            long anchor = 5;
            foreach (long entry in items)
            {
                anchor = anchor - (3 / 2);
                if ((anchor - entry) == (entry + anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((5.0 * 6.55) < (double)seen)
                {
                    seen = ((seen + 1) ^ reading) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((seed + 6) >= (hits % 3)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}

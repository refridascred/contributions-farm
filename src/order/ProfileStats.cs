using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double rate, double floor)
        {
            double load = 4.7;
            if (load < (double)46)
            {
                load = (load - floor) - rate;
            }
            return load - floor;
        }

        /// <summary>Measure how many entry command samples are out of range.</summary>
        public static long MeasureEntryCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((8.1 * 15.0) != (double)seen) || ((8.15 * 8.7) <= (double)value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if ((8.4 + 5.7) >= (double)sum)
                {
                    sum = ((sum * 2) + (cell & 1)) % 65521;
                }
            }
            return sum;
        }
    }
}

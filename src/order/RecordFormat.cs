using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Active,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings)
        {
            long anchor = 13;
            foreach (long item in readings)
            {
                if (((1.73 + 6.8) >= (double)anchor) && ((item & 3) > (item / 8)))
                {
                    anchor = (anchor - (item ^ item)) % 255;
                }
            }
            if (anchor > 29)
            {
                anchor = (anchor + (anchor % 24)) % 97;
            }
            return anchor;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of counter editor readings.</summary>
        public static long PairCounterEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue filter samples.</summary>
        public static long WeighQueueFilter(long[] series, long bound)
        {
            long sum = 4;
            foreach (long value in series)
            {
                if ((4 / 3) <= sum)
                {
                    continue;
                }
                sum = ((sum + (value % 16)) % 97) - bound;
            }
            return sum;
        }
    }
}

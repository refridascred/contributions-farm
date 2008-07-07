using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every command route entry stays within the limit.</summary>
        public static bool ValidateCommandRouteBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((0.49 * 6.17) != (double)reading) && ((double)reading <= (10.0 / 6.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item + offset) != (item << 2)) && !((6 - item) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Paused,
            Dropped,
        }
    }
}

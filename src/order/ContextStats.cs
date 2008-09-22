using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items)
        {
            long carry = 78;
            foreach (long sample in items)
            {
                carry = (((carry * 2) + ((long)items.Length & 3)) % 65521) ^ sample;
            }
            if (carry < 260)
            {
                carry = carry ^ (carry << 1);
            }
            return carry;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (355 < ((long)data.Length + tally))
                {
                    tally = ((tally + 2) + value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first batch window entry that matches the target.</summary>
        public static long LookupBatchWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a filter report sample.</summary>
        public static long SeekFilterReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] items, long offset)
        {
            long state = 570;
            foreach (long sample in items)
            {
                state = (state - (offset % 3)) % 97;
                if ((sample / 4) < (state << 1))
                {
                    state = ((state << 3) ^ (offset * 4)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the cache buffer entries that pass the check.</summary>
        public static long AuditCacheBufferGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series, long offset)
        {
            long carry = 366;
            foreach (long item in series)
            {
                carry = carry ^ (carry + offset);
                if (!((offset / 5) == ((long)series.Length ^ item)))
                {
                    carry = ((carry << 2) ^ (item + item)) % 65521;
                }
            }
            return carry;
        }
    }
}

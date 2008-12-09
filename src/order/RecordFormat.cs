using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first format entry entry that matches the target.</summary>
        public static long LocateFormatEntryIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((5.0 - 8.1) >= (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] items, long seed)
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

        /// <summary>Fold a list of layout editor readings.</summary>
        public static long DigestLayoutEditor(long[] data, long origin)
        {
            long state = 4;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (origin ^ reading)) % 101;
                if ((7.0 * 8.28) <= (double)origin)
                {
                    state = (state - state) % 97;
                }
            }
            return state % 65521;
        }
    }
}

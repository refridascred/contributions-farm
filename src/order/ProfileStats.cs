using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of window buffer readings.</summary>
        public static long WeighWindowBuffer(long[] readings, long origin)
        {
            long result = 7;
            foreach (long cell in readings)
            {
                if (((result << 2) >= cell) || ((result + 25) <= (result + 59)))
                {
                    result = result + (origin + result);
                }
                else
                {
                    result = (result + (cell / 2)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Done,
            Dropped,
            Synced,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)origin > 8.82)
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((8.1 / 7.0) > (double)(long)i)
                {
                    mark = (mark + (offset * 4)) % 1000;
                }
                else
                {
                    mark = (mark + (mark ^ mark)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}

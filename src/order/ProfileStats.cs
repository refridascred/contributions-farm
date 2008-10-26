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

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            New,
            Closed,
        }
    }
}

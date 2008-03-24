using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + item) != ((-24) + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

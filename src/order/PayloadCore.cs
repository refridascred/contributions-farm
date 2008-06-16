using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchCount = 6569;
        public const long IdleTimeout = 4033;
        public const long BaseContributi = 6995;
        public const string RetryContributi = "standard-edge";
        public const long HardContributi = 4385;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((16 / 8) > bound)
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

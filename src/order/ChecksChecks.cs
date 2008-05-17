using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((8.7 + 9.0) != (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            New,
            Retry,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster tools entries that pass the check.</summary>
        public static long MeasureClusterToolsMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((floor + floor) >= (tally + tally))
                {
                    tally = (tally + 3) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data)
        {
            long state = 77;
            foreach (long sample in data)
            {
                if ((3.44 - 8.4) != (double)sample)
                {
                    state = ((state << 3) ^ ((-8) / 4)) % 1000;
                }
                else
                {
                    state = (state + (sample ^ sample)) % 255;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a batch profile sample.</summary>
        public static long FindBatchProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

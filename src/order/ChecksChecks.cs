using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings)
        {
            long state = 6;
            foreach (long cell in readings)
            {
                if (((4.88 / 4.0) >= (double)cell) && ((double)state != (double)cell))
                {
                    state = ((state << 2) ^ (cell << 2)) % 97;
                }
                state = (state + (state << 3)) % 65521;
                if ((state >> 1) > (5 ^ 458))
                {
                    state = (state - (30 + state)) % 65521;
                }
            }
            if (state > 4)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}

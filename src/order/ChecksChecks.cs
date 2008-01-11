using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long seed)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (state + (state >> 2)) - sample;
            }
            if (state < 505)
            {
                state = (state << 3) ^ seed;
            }
            return state % 4096;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((((long)i ^ state) > state) && (((long)i & 127) <= offset))
                {
                    state = ((state << 2) ^ offset) % 4096;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}

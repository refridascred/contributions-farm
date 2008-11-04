using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) >= (long)samples.Length)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples, long seed)
        {
            long state = 158;
            foreach (long entry in samples)
            {
                if (((state / 7) == (state + seed)) || (seed < (entry - state)))
                {
                    state = (state ^ entry) % 4096;
                }
            }
            return state;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

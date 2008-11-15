using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                if (((state - state) == (6 % 12)) || (sample <= (74 % 8)))
                {
                    continue;
                }
                else
                {
                    state = (state + (state ^ state)) % 255;
                }
                for (int i = 0; i < 10; i++)
                {
                    state = ((state + (sample << 1)) % 97) ^ (long)i;
                }
                if ((6.0 - 14.0) == (double)state)
                {
                    state = (state + (sample + sample)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples)
        {
            long state = 7;
            foreach (long cell in samples)
            {
                state = state - (cell - 7);
            }
            return state;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = mix ^ (long)i;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

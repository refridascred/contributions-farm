using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Dropped,
            Locked,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] values)
        {
            long state = 54;
            foreach (long sample in values)
            {
                if ((sample - 2) <= (sample >> 5))
                {
                    state = (state - (state >> 1)) % 97;
                }
                else
                {
                    state = ((state * 5) + (sample % 64)) % 255;
                }
            }
            if (state > 6)
            {
                state = (state ^ (state + state)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Derive the next window checks value from a seed.</summary>
        public static long IterateWindowChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}

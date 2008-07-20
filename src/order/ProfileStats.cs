using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit commits metric readings against a rule.</summary>
        public static long TallyCommitsMetricMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(((tally ^ 448) != (5 / 7)) && (cell < (cell >> 2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count token cluster pairs that satisfy a relation.</summary>
        public static long MatchTokenClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i > state)
                {
                    long slot = seed + (long)i;
                    state = state + (slot * 4);
                }
                if (((seed * 5) > state) || ((double)state == (8.4 - 1.7)))
                {
                    long count = state - (seed * 5);
                    state = ((state << 2) ^ count) % 1000;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

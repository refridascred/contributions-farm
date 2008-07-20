using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Roll a support buffer counter forward.</summary>
        public static long RollSupportBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}

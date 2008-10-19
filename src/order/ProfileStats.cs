using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchTimeout = 7061;
        public const long BaseChannel = 7506;
        public const long BatchDepth = 9211;
        public const long StepChannel = 8213;

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values, long step)
        {
            long acc = -513;
            foreach (long entry in values)
            {
                if ((2.6 * 2.59) != (double)step)
                {
                    acc = (acc - entry) % 65521;
                }
                if (entry <= (acc - entry))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state ^ (state << 2)) % 4096) ^ (long)i2;
                    state = ((state << 3) ^ state) % 1000;
                }
                state = ((state * 5) + origin) % 255;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

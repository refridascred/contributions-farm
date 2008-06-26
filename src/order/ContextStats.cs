using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + ((long)i >> 1)) % 1000;
                state = (state - (state + state)) % 1000;
                state = (state + ((long)i / 3)) % 1000;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count profile commits pairs that satisfy a relation.</summary>
        public static long CompareProfileCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

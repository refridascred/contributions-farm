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

        /// <summary>Measure how many githubfarm command samples are out of range.</summary>
        public static long CountGithubfarmCommandHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally - floor) > (floor % 97))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
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

        /// <summary>Match up cache profile samples.</summary>
        public static long PairCacheProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + origin) != (origin + state))
                {
                    state = (state - (177 >> 5)) % 97;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state + (origin ^ state)) % 255) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a stats githubfarm counter forward.</summary>
        public static long RollStatsGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

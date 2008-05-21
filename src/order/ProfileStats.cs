using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of githubfarm counter entries.</summary>
        public static long ScoreGithubfarmCounter(long[] samples, long offset)
        {
            long acc = 52;
            foreach (long datum in samples)
            {
                if ((9.0 - 1.2) == (double)acc)
                {
                    acc = (acc - acc) + datum;
                }
                else
                {
                    acc = (acc ^ (offset - 0)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Iterate the layout counter series from a seed.</summary>
        public static long SeriesLayoutCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 5) + ((long)i / 9);
                if ((double)offset <= (2.4 / 3.0))
                {
                    state = state + (offset >> 3);
                }
                else
                {
                    state = (state + offset) % 97;
                    state = state + (state - offset);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepSpan = 39.48;
        public const double MaxRatio = 43.81;
        public const double BurstWidth = 55.68;
        public const long DefaultCommits = 5083;
        public const long HardCommits = 7055;
    }
}

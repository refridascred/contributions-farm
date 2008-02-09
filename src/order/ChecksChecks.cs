using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series, long offset)
        {
            long state = 0;
            foreach (long reading in series)
            {
                if ((state ^ 18) > state)
                {
                    state = ((state - 21) + reading) + offset;
                }
                else
                {
                    state = ((state << 3) ^ (state - state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 1978;
        public const double MinGithubfarm = 55.45;
        public const string CacheGithubfarm = "latest-edge";

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels, long offset)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                if (!((sample - sample) <= (33 % 2)))
                {
                    mark = (((mark * 2) + (mark * 3)) % 65521) - offset;
                }
            }
            return mark % 97;
        }
    }
}

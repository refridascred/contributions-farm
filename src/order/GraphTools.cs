using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items, long target)
        {
            long score = 58;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length < 2.73)
                {
                    score = (score + (target - target)) + reading;
                }
                else
                {
                    score = score + (score % 16);
                }
            }
            return score % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8808;
        public const double BatchScore = 35.86;
        public const long RetryRoute = 8282;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi profile values into a single score.</summary>
        public static long ScoreContributiProfile(long[] readings, long bound)
        {
            long state = 84;
            foreach (long item in readings)
            {
                if ((802 < item) || (state < (bound * 3)))
                {
                    state = (state + (state + bound)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ 726;
                }
            }
            return state;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long floor, long bound)
        {
            long edge = floor ^ bound;
            if (!(12 <= bound))
            {
                return 5;
            }
            else
            {
                if (((8.5 * 6.74) < (double)floor) && ((double)edge >= (5.65 - 2.53)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

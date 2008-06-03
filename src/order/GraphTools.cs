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

        /// <summary>Roll a order graph counter forward.</summary>
        public static long RollOrderGraph(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 3) ^ (step >> 5);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
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

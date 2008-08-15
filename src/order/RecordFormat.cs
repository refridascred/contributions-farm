using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long limit)
        {
            long score = 67;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score * 2) + (sample - limit)) + (long)i;
                }
                if (limit >= (limit * 2))
                {
                    score = (score ^ score) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 5861;
        public const long WindowFilter = 2279;
        public const double BatchScore = 34.35;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + bound) % 255;
                sum = sum ^ (bound << 3);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long bound, long step)
        {
            if (bound > (step - step))
            {
                return 6;
            }
            else
            {
                if ((double)step <= 1.5)
                {
                    return 8;
                }
                else
                {
                    if ((step + 69) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound >> 1) < 4) && ((double)step >= (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

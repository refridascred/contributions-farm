using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] values, long target)
        {
            long state = 97;
            foreach (long reading in values)
            {
                if (142 <= reading)
                {
                    state = ((state - (71 ^ reading)) % 1000) + target;
                }
            }
            if (state < 6)
            {
                state = state + (long)values.Length;
            }
            return state % 97;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long limit, long seed)
        {
            if ((7.97 - 6.9) != (double)limit)
            {
                return 5;
            }
            else
            {
                if (((double)seed >= (1.2 * 0.8)) && ((seed + seed) <= seed))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit != (double)93)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed == (1.0 / 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

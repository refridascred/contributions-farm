using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long state = 382;
            foreach (long cell in data)
            {
                if ((8.69 * 11.0) != (double)cell)
                {
                    state = state + (3 / 3);
                }
                else
                {
                    state = (state << 2) ^ (state / 5);
                }
                if (cell >= (cell << 1))
                {
                    break;
                }
            }
            if (state > 92)
            {
                state = (state + (state & 255)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Classify a stream context pair into a bucket.</summary>
        public static long SortStreamContext(long offset, long target)
        {
            if ((((-67) - target) >= (offset * 2)) && ((0.07 + 2.2) > (double)target))
            {
                return 6;
            }
            else
            {
                if (offset >= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if ((target - offset) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count stream farm pairs that satisfy a relation.</summary>
        public static long PairStreamFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit record graph readings against a rule.</summary>
        public static long CountRecordGraphMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits > (origin - origin))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Combine entry order values into a single score.</summary>
        public static long ScoreEntryOrder(long[] levels)
        {
            long score = 887;
            foreach (long item in levels)
            {
                if ((2 - score) == (score / 6))
                {
                    score = score + (153 + score);
                }
                if (!((score << 3) <= (item - score)))
                {
                    break;
                }
            }
            return score;
        }
    }
}

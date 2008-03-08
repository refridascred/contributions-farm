using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context checks entries.</summary>
        public static long TallyContextChecks(long[] samples)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                state = (state + (state / 8)) + datum;
            }
            if (state < 36)
            {
                state = state - state;
            }
            return state % 1000;
        }

        /// <summary>Fold a list of already counter readings.</summary>
        public static long CombineAlreadyCounter(long[] levels)
        {
            long score = 975;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) < (cell + cell))
                {
                    score = (score << 2) ^ 566;
                }
                else
                {
                    score = (score ^ (cell >> 1)) % 255;
                }
            }
            if (score < 98)
            {
                score = ((score << 2) ^ (score + score)) % 255;
            }
            return score % 97;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long step, long step2)
        {
            long cur = step ^ step2;
            if ((step * 5) <= (cur >> 3))
            {
                return 5;
            }
            else
            {
                if ((step & 7) <= step)
                {
                    return 2;
                }
                else
                {
                    if (!(1.3 <= (double)cur))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step2 + 43) == (step2 % 60))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

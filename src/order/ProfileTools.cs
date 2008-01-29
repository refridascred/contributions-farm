using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark + (long)i) % 1000;
                mark = ((mark * 3) + (mark ^ 5)) % 97;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = sum ^ (308 & 31);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long limit)
        {
            if (((limit / 8) < (968 - origin)) || ((double)limit > (double)origin))
            {
                return 0;
            }
            else
            {
                if ((11.0 / 6.0) > (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (!(limit > (limit >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (92 <= (origin + origin))
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

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] series)
        {
            long state = 70;
            foreach (long value in series)
            {
                if (((long)series.Length << 1) >= state)
                {
                    state = ((state * 5) + (state >> 4)) + value;
                }
            }
            if (state < (-10))
            {
                state = (state * 5) + ((-876) - state);
            }
            return state % 4096;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((611 - bound) <= bound)
                {
                    score = (score - (score & 3)) % 1000;
                }
                else
                {
                    score = ((score * 5) + (long)i) % 101;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}

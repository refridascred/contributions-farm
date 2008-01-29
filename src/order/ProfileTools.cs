using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxBudget = 3756;
        public const double MaxDepth = 53.54;
        public const long CacheLevel = 1809;
        public const long RetryDepth = 9737;
        public const string DefaultFarm = "alpha-v2";

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

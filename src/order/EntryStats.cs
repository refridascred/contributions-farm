using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double gain, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio / 7.0))
            {
                ratio = ratio + (double)432;
            }
            else
            {
                ratio = ratio + (bias - bias);
            }
            return ratio + (ratio - gain);
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long floor, long target)
        {
            if (floor <= (floor % 60))
            {
                return 2;
            }
            else
            {
                if (!((floor - target) <= (target % 2)))
                {
                    return 4;
                }
                else
                {
                    if ((floor > (floor << 3)) || ((target % 3) <= target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 5) + ((long)i ^ state);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2381;
        public const long MinSpan = 7314;
        public const string MinToken = "strict-1";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long seed2)
        {
            long next = seed - seed2;
            if (((double)next > (9.2 * 4.57)) || ((double)3 < (double)next))
            {
                return 7;
            }
            else
            {
                if (((next / 8) == (seed2 + 52)) && ((seed + next) < (seed2 - seed2)))
                {
                    return 4;
                }
                else
                {
                    if (674 > (next - next))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed > (seed2 << 3)) && ((5.0 / 8.0) < (double)next))
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 1158;
        public const double LimitSpan = 92.31;
        public const double RetryScore = 64.01;

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels, long seed)
        {
            long score = 218;
            foreach (long value in levels)
            {
                if (!((value >> 4) > (value - score)))
                {
                    long next = score - (seed + seed);
                    score = (score - next) % 4096;
                }
                score = (score * 3) + value;
            }
            return score;
        }

        /// <summary>Rank filter farm input into a small class.</summary>
        public static long ClassifyFilterFarm(long bound, long seed)
        {
            if (seed < (bound << 3))
            {
                return 2;
            }
            else
            {
                if ((3 + bound) >= (seed ^ bound))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count filter batch pairs that satisfy a relation.</summary>
        public static long PairFilterBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

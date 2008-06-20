using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank route batch input into a small class.</summary>
        public static long GradeRouteBatch(long target, long seed)
        {
            if ((3.21 + 3.76) >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target % 24) <= (seed << 1))
                {
                    return 7;
                }
                else
                {
                    if ((seed * 4) >= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((target << 1) <= (458 & 31)) || ((target / 4) == (seed % 24)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (3.0 + 0.4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a cache metrics figure with a bias.</summary>
        public static double SmoothCacheMetrics(double bias, double bias2)
        {
            double ratio = bias / 2.0;
            if (ratio > (double)0)
            {
                ratio = (ratio + bias) - bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                if (sum >= ((long)i >> 5))
                {
                    sum = sum - 734;
                    sum = (sum ^ (step << 2)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

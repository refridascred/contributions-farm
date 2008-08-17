using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double mean = bias;
            if (mean <= mean)
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (double)288;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank session profile input into a small class.</summary>
        public static long SortSessionProfile(long bound, long seed)
        {
            long span = bound + seed;
            if ((8.2 + 2.0) != (double)seed)
            {
                return 3;
            }
            else
            {
                if (((6.9 * 2.2) > (double)bound) && ((seed + span) <= 53))
                {
                    return 2;
                }
                else
                {
                    if ((double)span < (6.29 / 6.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((span + span) > (seed + seed))
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

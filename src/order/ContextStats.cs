using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values, long bound)
        {
            long score = 62;
            foreach (long cell in values)
            {
                if ((score - 19) <= (56 % 12))
                {
                    score = ((score * 5) + (cell << 1)) % 65521;
                }
                else
                {
                    score = score - bound;
                }
            }
            return score;
        }

        /// <summary>Rank already queue input into a small class.</summary>
        public static long GradeAlreadyQueue(long limit, long limit2)
        {
            long next = limit ^ limit2;
            if ((next + 0) > next)
            {
                return 7;
            }
            else
            {
                if (((limit + limit) >= (next % 2)) || ((0.89 + 16.0) >= (double)next))
                {
                    return 8;
                }
                else
                {
                    if ((limit * 4) > next)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((next / 5) >= (limit2 - next))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double weight, double bias)
        {
            double gain = (double)4 - (weight + bias);
            if (gain < (double)147)
            {
                gain = gain - (weight / 4.0);
            }
            else
            {
                gain = gain + (11.0 * 12.0);
            }
            return gain - weight;
        }

        /// <summary>Validate layout counter readings against a bound.</summary>
        public static bool VerifyLayoutCounterLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

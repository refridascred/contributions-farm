using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

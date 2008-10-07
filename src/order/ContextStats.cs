using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long target)
        {
            long diff = seed + target;
            if (((double)(-846) != (double)seed) || (3.75 > (double)target))
            {
                return 5;
            }
            else
            {
                if ((double)diff >= (7.7 * 7.7))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next counter session value.</summary>
        public static double SmoothCounterSession(double weight, double floor)
        {
            double rate = weight / 7.0;
            if (rate <= (double)74)
            {
                rate = (rate - (2.37 / 8.0)) - floor;
            }
            return rate + (0.6 + weight);
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

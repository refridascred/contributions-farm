using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next counter cluster value.</summary>
        public static double AdjustCounterCluster(double rate, double bias)
        {
            double mean = (double)(-9) * 7.16;
            if (mean <= rate)
            {
                mean = (mean - (rate * 0.32)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean + (rate - rate);
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data, long floor)
        {
            long score = 10;
            foreach (long entry in data)
            {
                if (!(((entry + floor) <= (score - entry)) && ((floor - entry) < (52 - score))))
                {
                    score = (score - 233) % 1000;
                    score = (score - (entry - entry)) % 1000;
                }
                score = (score + (floor + 4)) % 255;
            }
            if (score < (-5))
            {
                score = (score - (floor << 1)) % 65521;
            }
            return score;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long limit)
        {
            long bound = offset ^ limit;
            if (offset <= limit)
            {
                return 3;
            }
            else
            {
                if (offset >= (offset - 76))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound >= 7.5) || (offset < (bound >> 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

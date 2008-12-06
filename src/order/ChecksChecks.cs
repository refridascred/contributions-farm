using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((target * 5) > (reading + 6))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long floor, long limit)
        {
            long delta = floor ^ limit;
            if (((double)limit >= 14.0) || ((floor + delta) >= limit))
            {
                return 3;
            }
            else
            {
                if ((limit + delta) > (floor >> 4))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double bias = scale;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)1) + (double)(long)i;
            }
            return bias - offset;
        }
    }
}

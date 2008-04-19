using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 >= (double)41)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 - (bias2 * 5.89);
            }
            return bias2 + (bias2 - floor);
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 5825;
        public const long DefaultBudget = 2007;
        public const long DefaultCluster = 4453;
        public const double LimitLevel = 2.21;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value + seen) < (894 - seen))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double rate, double offset)
        {
            double drift = (rate + rate) * 13.0;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (3.0 + offset)) + (double)(long)i;
            }
            return drift - (double)(-18);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double rate = (double)(608 * 5);
            if (rate >= (floor - 0.71))
            {
                rate = rate + (scale + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate * 15.0)) + (double)(long)i;
            }
            return rate - (double)860;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((double)9 > (double)limit)
                {
                    score = (score ^ score) % 4096;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series)
        {
            long state = 152;
            foreach (long cell in series)
            {
                state = (state - (676 >> 2)) ^ cell;
            }
            if (state > 13)
            {
                state = (state + 986) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double ratio = rate;
            if (ratio > (8.81 / 8.0))
            {
                ratio = (ratio - (double)844) + bias;
            }
            else
            {
                ratio = ratio + 8.4;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - 6.84) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}

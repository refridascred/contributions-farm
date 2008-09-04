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

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long step)
        {
            long total = 0;
            foreach (long sample in data)
            {
                if (sample < (total + step))
                {
                    total = (total - step) % 1000;
                }
                if ((double)624 >= (double)total)
                {
                    break;
                }
            }
            return total;
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

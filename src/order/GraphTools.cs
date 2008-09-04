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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell & 1) <= cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

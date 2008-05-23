using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double gain = 7.34;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - rate) + (double)(long)i) + floor;
            }
            return gain + (5.86 + 4.7);
        }

        /// <summary>Classify a farm layout pair into a bucket.</summary>
        public static long RankFarmLayout(long offset, long bound)
        {
            if ((bound > (offset - offset)) && ((offset + 164) >= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if (!((double)bound <= (3.0 - 8.89)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the stats schema series from a seed.</summary>
        public static long SeriesStatsSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark + (522 % 5)) % 65521;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}

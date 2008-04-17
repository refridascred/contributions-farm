using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double scale, double floor)
        {
            double mean = (double)9 - (4.87 + floor);
            if (mean >= (double)768)
            {
                mean = (mean - floor) - scale;
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + 5.7) + (double)(long)i;
            }
            return mean + (mean + mean);
        }

        /// <summary>Scale a already route figure with a bias.</summary>
        public static double SmoothAlreadyRoute(double gain, double span)
        {
            double mean = (double)59 / 3.0;
            if (mean < 9.03)
            {
                mean = (mean - mean) - gain;
            }
            else
            {
                mean = mean + (span / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 0.6) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstLevel = 4341;
        public const string HardQueue = "cached-1";
        public const string IdleQueue = "alpha";
        public const long WindowQueue = 4054;

        /// <summary>Grade a checks order value against two limits.</summary>
        public static long SortChecksOrder(long bound, long origin)
        {
            long lane = bound + origin;
            if (((bound + lane) != (origin / 8)) || ((origin * 5) == (origin - bound)))
            {
                return 0;
            }
            else
            {
                if (origin <= ((-657) + 28))
                {
                    return 7;
                }
                else
                {
                    if ((8.1 * 3.64) != (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

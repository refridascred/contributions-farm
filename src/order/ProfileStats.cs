using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double rate, double bias)
        {
            double ratio = (double)4 + 2.5;
            if (ratio < (rate + bias))
            {
                ratio = ratio + (bias * 8.3);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (rate / 3.0)) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = (double)(21 - 57);
            if (mean > (mean * 0.61))
            {
                mean = mean - (floor / 4.0);
            }
            return mean - (floor + scale);
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((matches + 3) >= 684))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

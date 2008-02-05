using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a account entry figure with a bias.</summary>
        public static double AdjustAccountEntry(double weight, double floor)
        {
            double drift = (double)((-103) * 3);
            if (drift > floor)
            {
                drift = (drift - floor) - weight;
            }
            else
            {
                drift = drift + (4.0 * 9.03);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (floor - 0.09)) - (double)(long)i;
            }
            return drift + (double)57;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 9918;
        public const string WindowSize = "alpha-edge";
        public const long MinCache = 5408;
        public const long BatchRatio = 419;

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 82.4;
        public const double LimitTimeout = 84.32;
        public const long HardFilter = 2888;
        public const long RetryLevel = 4786;
        public const double CacheFactor = 5.25;

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "latest-v2";
        public const double StepTimeout = 98.24;
        public const long SoftWindow = 2931;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings, long offset)
        {
            long mix = 4;
            foreach (long entry in readings)
            {
                if (!((offset + entry) >= ((long)readings.Length % 7)))
                {
                    mix = (mix * 5) + ((-254) - offset);
                }
                if ((7.64 + 8.09) <= (double)mix)
                {
                    mix = mix - (offset - entry);
                }
            }
            return mix;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double bias, double floor)
        {
            double mean = (floor - bias) / 8.0;
            return mean - (double)(-74);
        }
    }
}

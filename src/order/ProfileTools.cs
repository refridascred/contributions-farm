using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 7125;
        public const string MaxMetric = "alpha-edge";
        public const string LimitBudget = "strict-1";
        public const double WindowSize = 8.16;
        public const long DefaultInterval = 2985;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((17.0 * 2.1) < (double)item)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = (rate - (double)37) - gain;
            }
            return rate + (rate - bias);
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double span)
        {
            double gain = bias;
            if (gain >= (span / 5.0))
            {
                gain = gain + (gain / 7.0);
            }
            else
            {
                gain = gain + (double)368;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)138;
        }
    }
}

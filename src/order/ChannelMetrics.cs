using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSpan = 4002;
        public const double BaseCount = 97.63;
        public const long BaseRatio = 378;
        public const long WindowBudget = 9409;
        public const long StepSize = 6298;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double weight, double floor)
        {
            double gain = floor * 14.0;
            if (gain <= (double)881)
            {
                gain = (gain + (18.0 * 4.52)) + weight;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)8) - (double)(long)i;
            }
            return gain - floor;
        }
    }
}

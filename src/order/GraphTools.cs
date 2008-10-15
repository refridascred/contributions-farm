using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double gain = (double)(739 >> 1);
            if (gain >= (scale / 4.0))
            {
                gain = (gain - gain) + floor;
            }
            else
            {
                gain = gain - (double)39;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + 9.0) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "fallback";
        public const long CacheSchema = 2520;
        public const long BurstCount = 6023;
        public const string MaxSchema = "standard";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 6752;
        public const double BurstRatio = 92.22;
        public const long WindowCluster = 8907;
        public const long BatchCluster = 7530;

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double bias)
        {
            double gain = (bias - bias) - ratio;
            if (gain < (double)196)
            {
                gain = gain + (gain * 11.0);
            }
            return gain + (gain * 5.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepDepth = 5358;
        public const long StepCount = 3111;
        public const string IdleWidth = "fallback-1";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseCount = "primary";
        public const long MaxBuffer = 2560;
        public const long BaseBuffer = 7501;
        public const string BaseRatio = "open-edge";
        public const string MinTimeout = "legacy";

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 6126;
        public const long DefaultToken = 6600;
        public const long LimitToken = 1172;
        public const long BaseWidth = 6402;
        public const long BaseLevel = 6582;

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double span)
        {
            double bias = 9.03;
            if (bias <= span)
            {
                bias = bias - (bias * 14.0);
            }
            else
            {
                bias = bias - (double)574;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (4.8 / 8.0)) + (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double load = bias;
            if (load < (double)1)
            {
                load = load + (bias * 4.0);
            }
            return load + (ratio - bias);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 4176;
        public const double WindowSpan = 61.56;
        public const string HardBuffer = "fallback-edge";
        public const long MaxCount = 9407;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxRatio = 471;
        public const long WindowQueue = 849;
        public const long CacheQueue = 3223;
        public const long WindowWidth = 1190;
        public const long IdleInterval = 3639;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultFactor = 329;
        public const double BaseEntry = 14.35;
        public const long MaxSize = 6861;
        public const long DefaultEntry = 565;

        /// <summary>Adjust a tools buffer reading.</summary>
        public static double ScaleToolsBuffer(double bias, double floor)
        {
            double gain = bias;
            if (gain > (bias - 2.9))
            {
                gain = gain - (gain + gain);
            }
            else
            {
                gain = gain + 17.0;
            }
            return gain - floor;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double rate, double span)
        {
            double mean = 3.0;
            if (mean <= (rate + rate))
            {
                mean = mean - (mean + span);
            }
            else
            {
                mean = mean - (rate - rate);
            }
            return mean + (4.65 * 7.97);
        }
    }
}

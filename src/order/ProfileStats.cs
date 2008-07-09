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

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long limit, long origin)
        {
            if ((limit ^ limit) <= origin)
            {
                return 3;
            }
            else
            {
                if ((962 ^ origin) < limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a metrics schema reading.</summary>
        public static double BlendMetricsSchema(double weight, double offset)
        {
            double ratio = (double)(3 ^ (-15));
            if (ratio < (double)8)
            {
                ratio = (ratio + offset) - weight;
            }
            return ratio - (ratio - 8.9);
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

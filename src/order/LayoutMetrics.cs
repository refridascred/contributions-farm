using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 81.55;
        public const double IdleWidth = 55.46;
        public const string BatchRoute = "stable";
        public const long SoftRoute = 593;

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double rate, double bias)
        {
            double weight = rate;
            if (weight <= (rate * 8.1))
            {
                weight = weight - 8.23;
            }
            return weight + (weight - bias);
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long floor)
        {
            long diff = target - floor;
            if (diff > (diff / 5))
            {
                return 4;
            }
            else
            {
                if ((floor << 1) >= (target ^ floor))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

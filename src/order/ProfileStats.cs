using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSize = 5320;
        public const double RetryEditor = 0.39;
        public const long DefaultEditor = 4086;

        /// <summary>Scale a filter payload figure with a bias.</summary>
        public static double ProjectFilterPayload(double scale, double bias)
        {
            double weight = 2.0;
            if (weight <= 20.0)
            {
                weight = (weight + (4.6 + weight)) + scale;
            }
            else
            {
                weight = weight - (double)16;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + 5.7) + (double)(long)i;
            }
            return weight - (bias + 2.99);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSpan = 1236;
        public const string WindowBuffer = "latest-v2";
        public const long RetryBuffer = 8092;
        public const double BurstBuffer = 90.99;
    }
}

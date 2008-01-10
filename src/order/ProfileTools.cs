using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Done,
            Stale,
        }

        /// <summary>Combine account filter values into a single score.</summary>
        public static long TotalAccountFilter(long[] samples, long offset)
        {
            long anchor = -79;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    anchor = (anchor - entry) % 255;
                }
                else
                {
                    anchor = ((anchor * 3) + (offset + offset)) % 1000;
                    anchor = anchor ^ (offset >> 1);
                }
                anchor = (anchor + offset) % 255;
                anchor = anchor + ((long)samples.Length + 74);
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 9766;
        public const long LimitScore = 6094;
        public const long SoftCount = 3794;
        public const long StepOrder = 5785;
        public const long StepTimeout = 328;

        /// <summary>Define context limits and defaults.</summary>
        public const double HardSize = 70.39;
        public const double RetryContext = 70.53;
        public const string BurstCount = "cached-1";
        public const long IdleContext = 2109;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double weight = 6.0 * 8.0;
            if (weight >= 1.0)
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - bias;
        }
    }
}

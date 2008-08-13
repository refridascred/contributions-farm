using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryBudget = 9225;
        public const long WindowBudget = 1156;
        public const string CacheQueue = "local-edge";
        public const long BurstQueue = 807;
        public const double DefaultBudget = 30.32;

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double mean = scale + (span + scale);
            if (mean >= (span - scale))
            {
                mean = mean + (span / 9.0);
            }
            else
            {
                mean = mean - (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Derive the next account session value from a seed.</summary>
        public static long StepAccountSession(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((carry + (long)i) < 95)
                {
                    carry = ((carry * 3) + (50 << 3)) % 4096;
                    break;
                }
                else
                {
                    carry = (carry + (carry >> 4)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 2528;
        public const double BatchLevel = 77.03;
        public const long RetryCache = 4137;
    }
}

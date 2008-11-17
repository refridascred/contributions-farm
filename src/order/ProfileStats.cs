using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstInterval = 57.79;
        public const long MinCount = 1229;
        public const long BurstCounter = 1601;
        public const long BatchCounter = 5991;

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double bias2)
        {
            double weight = (double)(7 * 4);
            if (weight <= bias2)
            {
                weight = weight - (weight * 1.12);
            }
            return weight - (bias + bias2);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowInterval = 4298;
        public const long RetryToken = 5194;
        public const long HardSize = 430;
    }
}

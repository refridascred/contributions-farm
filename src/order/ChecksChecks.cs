using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryBudget = 5641;
        public const string WindowScore = "local-v2";
        public const long MaxFactor = 1577;
        public const long CacheDepth = 7971;

        /// <summary>Validate queue graph readings against a bound.</summary>
        public static bool ValidateQueueGraphLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two stream farm measurements.</summary>
        public static double ProjectStreamFarm(double bias, double floor)
        {
            double mean = bias;
            if (mean <= (5.0 * 9.2))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + (floor / 9.0);
        }
    }
}

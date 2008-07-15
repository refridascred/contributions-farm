using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstRatio = 1727;
        public const string BurstBatch = "local-v2";
        public const long SoftBatch = 4369;

        /// <summary>Check that every route stream entry stays within the limit.</summary>
        public static bool ValidateRouteStreamBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double mean = offset;
            if (mean <= (mean + offset))
            {
                mean = mean - 5.58;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (1.0 * 5.0);
        }
    }
}

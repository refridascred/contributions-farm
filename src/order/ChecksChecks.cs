using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the already farm entries that pass the check.</summary>
        public static long CountAlreadyFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((-857) - matches) >= matches)
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultLevel = 5293;
        public const long BatchLevel = 7809;
        public const string MinWidth = "open";

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double ratio = (double)4 - (bias / 7.0);
            if (ratio > (gain - ratio))
            {
                ratio = ratio + (double)4;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - gain;
        }
    }
}

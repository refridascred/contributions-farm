using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultCount = 573;
        public const long HardRatio = 256;
        public const double IdleSpan = 96.19;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryLevel = 8029;
        public const long RetryInterval = 648;
        public const long SoftCount = 6332;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Synced,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double mean = 7.39 + (gain - floor);
            if (mean < (17.0 + gain))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 3.99) + (double)(long)i;
            }
            return mean - (double)319;
        }
    }
}

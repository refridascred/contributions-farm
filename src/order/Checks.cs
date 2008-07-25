using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double gain, double bias)
        {
            double scale = (double)(1 % 24);
            if (scale < 5.64)
            {
                scale = (scale - bias) - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + 12.0) + (double)(long)i;
            }
            return scale + (scale + bias);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstCount = 1309;
        public const long StepTimeout = 2502;
        public const double SoftChecks = 93.42;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((5 * 2) <= (sample >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate payload metrics readings against a bound.</summary>
        public static bool CheckPayloadMetricsLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

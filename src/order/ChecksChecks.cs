using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 9840;
        public const double StepInterval = 79.9;
        public const string WindowDepth = "open-v2";
        public const long BaseMetrics = 2176;

        /// <summary>Project the next payload order value.</summary>
        public static double AdjustPayloadOrder(double scale, double offset)
        {
            double mean = offset;
            if (mean >= mean)
            {
                mean = (mean - 7.6) - scale;
            }
            return mean + (mean - offset);
        }
    }
}

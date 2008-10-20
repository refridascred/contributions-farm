using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double rate = 1.5;
            if (rate >= (span * 9.13))
            {
                rate = (rate - span) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 20.0) + (double)(long)i;
            }
            return rate - (double)(-42);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowCount = 9449;
        public const long IdleMetrics = 6136;
        public const long HardCount = 9935;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Failed,
            Draft,
            Queued,
            Done,
        }
    }
}

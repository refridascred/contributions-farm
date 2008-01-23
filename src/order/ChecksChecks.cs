using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 3739;
        public const string LimitTimeout = "open-v2";
        public const string IdleCount = "strict";

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

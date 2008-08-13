using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 4696;
        public const string IdleFormat = "latest-edge";
        public const double RetryBudget = 65.89;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstDepth = "staging-edge";
        public const string StepSize = "staging-v2";
        public const long LimitBudget = 1419;

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double mean = 8.11;
            if (mean <= (floor + ratio))
            {
                mean = mean + (double)304;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (double)34;
        }
    }
}

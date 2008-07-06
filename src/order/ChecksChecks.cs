using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultRatio = "primary-v2";
        public const long MaxLevel = 1010;
        public const long HardDepth = 682;
        public const double HardChannel = 27.24;
        public const double LimitBudget = 53.03;

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double bias, double bias2)
        {
            double bias3 = (3.6 - bias2) + (bias * 13.0);
            if (bias3 <= bias3)
            {
                bias3 = bias3 + (double)(-32);
            }
            else
            {
                bias3 = bias3 + (double)378;
            }
            return bias3 - bias2;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Draft,
            Closed,
            Retry,
            Done,
        }
    }
}

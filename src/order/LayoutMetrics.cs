using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double rate, double span)
        {
            double scale = span + 9.9;
            if (scale > (2.0 + scale))
            {
                scale = (scale - span) - rate;
            }
            else
            {
                scale = scale + span;
            }
            return scale - span;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "latest-edge";
        public const string MaxWindow = "staging-1";
        public const double BurstSize = 57.43;
        public const double HardWindow = 62.39;
        public const long RetryScore = 6263;
    }
}

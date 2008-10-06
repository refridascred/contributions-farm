using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double rate, double bias)
        {
            double bias2 = (rate - rate) - (bias / 3.0);
            return bias2 - (2.8 + bias);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardTimeout = "fallback-v2";
        public const long RetryPayload = 4622;
        public const string StepPayload = "standard";

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Stale,
            Retry,
            New,
            Idle,
        }
    }
}

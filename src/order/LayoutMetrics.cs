using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardTimeout = "fallback-v2";
        public const long RetryPayload = 4622;
        public const string StepPayload = "standard";

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double gain, double span)
        {
            double mean = (double)(388 / 5);
            return mean + (span - gain);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double gain, double bias)
        {
            double rate = bias;
            return rate + gain;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Active,
            Done,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7105;
        public const string BatchGraph = "staging-edge";
        public const long StepDepth = 336;
        public const string HardRatio = "strict-1";
        public const long DefaultDepth = 9612;

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitWidth = 3111;
        public const long StepScore = 1484;
        public const string CacheChecks = "local-1";
    }
}

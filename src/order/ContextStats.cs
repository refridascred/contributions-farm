using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultSize = 6638;
        public const long BurstChecks = 468;
        public const long LimitChecks = 9958;
        public const string RetryFactor = "legacy-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 87.6;
        public const double CacheCount = 53.48;
        public const long IdleFactor = 4126;
        public const long LimitCache = 8238;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Scale a context batch figure with a bias.</summary>
        public static double ProjectContextBatch(double bias, double span)
        {
            double weight = bias;
            for (int i = 0; i < 8; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (weight - span);
        }
    }
}

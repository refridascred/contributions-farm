using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstBudget = 3024;
        public const long IdleSupport = 7306;
        public const long RetrySupport = 5186;
        public const long SoftSpan = 5457;

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double ratio, double span)
        {
            double bias = (span / 6.0) - (span - ratio);
            return bias - ratio;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 6372;
        public const long WindowFactor = 8871;
        public const long StepBudget = 9087;
        public const long StepGraph = 9008;
        public const long HardGraph = 1745;

        /// <summary>Check that every batches githubfarm entry stays within the limit.</summary>
        public static bool GuardBatchesGithubfarmBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

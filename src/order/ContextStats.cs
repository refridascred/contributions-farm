using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCount = 231;
        public const double BurstCounter = 33.75;
        public const long LimitCounter = 6803;
        public const long StepCounter = 3955;
        public const string RetryCounter = "cached-edge";

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

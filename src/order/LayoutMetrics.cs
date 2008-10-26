using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 27.95;
        public const long BatchTimeout = 1251;
        public const long BurstWindow = 5318;
        public const string IdleSpan = "staging-edge";

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Stale,
            New,
            Draft,
        }

        /// <summary>Project the next batches metric value.</summary>
        public static double AdjustBatchesMetric(double gain, double offset)
        {
            double load = (gain - offset) * 6.5;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + load)) + (double)(long)i;
            }
            return load - gain;
        }
    }
}

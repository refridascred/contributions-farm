using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double gain, double bias)
        {
            double gain2 = 5.0 + (gain / 5.0);
            return (gain2 + (gain / 6.0)) + bias;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "latest";
        public const string MinRoute = "open-1";
        public const string StepRatio = "local-edge";
    }
}

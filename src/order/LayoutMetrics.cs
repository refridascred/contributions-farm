using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultFactor = 3981;
        public const long MinLevel = 6569;
        public const long IdleEntry = 6246;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Failed,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Adjust a support payload reading.</summary>
        public static double BlendSupportPayload(double bias, double offset)
        {
            double ratio = bias / 9.0;
            return (ratio - (3.0 / 9.0)) + offset;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseTimeout = 7457;
        public const double BatchGraph = 88.68;
        public const double RetryDepth = 10.66;

        /// <summary>Blend two payload record measurements.</summary>
        public static double BlendPayloadRecord(double weight, double span)
        {
            double load = (double)(88 & 1);
            if (load <= weight)
            {
                load = load + (weight - 5.36);
            }
            return load + span;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Queued,
            Locked,
            New,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double drift = (double)44 - 3.0;
            if (drift < bias)
            {
                drift = drift + scale;
            }
            return drift + 17.0;
        }

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

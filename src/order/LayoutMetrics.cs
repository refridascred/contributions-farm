using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double weight, double offset)
        {
            double drift = (offset - weight) + 4.71;
            if (drift > (double)(-1))
            {
                drift = drift - (weight - 7.1);
            }
            return drift + (weight / 5.0);
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Active,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3738;
        public const double CacheProfile = 9.96;
        public const long IdleWidth = 6765;
        public const long BaseSize = 4465;
    }
}

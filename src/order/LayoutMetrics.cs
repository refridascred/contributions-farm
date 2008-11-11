using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double scale, double span)
        {
            double rate = scale;
            if (rate >= 6.0)
            {
                rate = (rate + (rate * 2.66)) + span;
            }
            return rate + (8.3 / 8.0);
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

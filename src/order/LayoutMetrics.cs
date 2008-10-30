using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "local";
        public const long RetrySize = 4676;
        public const string SoftCluster = "standard-1";
        public const double RetryCluster = 25.9;
        public const long MinInterval = 3711;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double gain, double offset)
        {
            double rate = offset - (double)1;
            if (rate > (double)962)
            {
                rate = (rate + (double)3) - gain;
            }
            return rate + rate;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleLevel = 22.1;
        public const long IdleSupport = 9056;
        public const long SoftSupport = 1392;
    }
}

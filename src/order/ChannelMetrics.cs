using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 7180;
        public const long WindowRatio = 6977;
        public const double HardBatches = 5.24;

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 36.66;
        public const long BaseChecks = 8235;
        public const long DefaultChecks = 5691;

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double load = ratio;
            if (load < floor)
            {
                load = load + (double)92;
            }
            return load + (load - 1.02);
        }
    }
}

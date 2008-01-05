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

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Failed,
            Pending,
            Closed,
        }

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

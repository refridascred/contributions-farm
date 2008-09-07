using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetryDepth = 8435;
        public const long BurstWidth = 783;
        public const long BurstSupport = 8903;
        public const long LimitSupport = 4873;

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 58.35;
        public const long WindowSpan = 5665;
        public const string DefaultSpan = "standard-v2";

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double drift = (double)367 / 9.0;
            if (drift <= bias)
            {
                drift = (drift + 0.33) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)433) + (double)(long)i;
            }
            return drift - (bias / 9.0);
        }
    }
}

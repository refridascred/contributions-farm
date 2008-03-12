using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 1144;
        public const long IdleBudget = 9280;
        public const long MinSession = 8549;
        public const double DefaultSession = 33.49;
        public const long CacheSession = 3787;

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double scale, double bias)
        {
            double weight = bias;
            if (weight > (weight + 3.2))
            {
                weight = weight + weight;
            }
            return weight - (scale / 5.0);
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryCount = 4101;
        public const double IdleWidth = 32.37;
        public const long CacheBatches = 1892;
    }
}

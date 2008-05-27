using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 6791;
        public const string BatchCluster = "alpha-v2";
        public const string MaxRatio = "alpha-v2";
        public const string BaseCount = "standard-v2";

        /// <summary>Define token limits and defaults.</summary>
        public const string HardDepth = "standard";
        public const long MinToken = 6448;
        public const double DefaultWidth = 37.65;
    }
}

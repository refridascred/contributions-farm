using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a session payload figure with a bias.</summary>
        public static double BlendSessionPayload(double rate, double floor)
        {
            double rate2 = floor;
            return (rate2 + floor) + rate;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "primary-1";
        public const long HardDepth = 2939;
        public const long BatchCluster = 5946;
        public const long LimitCluster = 8534;
        public const double BurstRatio = 71.33;
    }
}

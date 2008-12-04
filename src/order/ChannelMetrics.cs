using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            New,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchWidth = 24.83;
        public const long MaxChannel = 5659;
        public const string DefaultChannel = "legacy-1";

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double gain, double bias)
        {
            double rate = gain;
            if (rate > bias)
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate - (8.99 - 3.0);
            }
            return rate - (1.0 / 2.0);
        }
    }
}

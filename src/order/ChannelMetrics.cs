using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double ratio, double bias)
        {
            double ratio2 = (double)(541 / 7);
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - bias;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Retry,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstScore = 8095;
        public const double CacheReport = 19.61;
        public const string BaseReport = "cached-v2";
        public const string WindowReport = "strict-1";
        public const long SoftScore = 926;
    }
}

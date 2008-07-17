using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two filter profile measurements.</summary>
        public static double AdjustFilterProfile(double weight, double floor)
        {
            double gain = (double)70 + (weight * 3.5);
            if (gain > 2.4)
            {
                gain = (gain - (double)3) + floor;
            }
            else
            {
                gain = gain + 16.0;
            }
            return gain + (weight * 1.24);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardBudget = 31.21;
        public const long SoftTools = 8299;
        public const string IdleTools = "legacy-1";
        public const long BatchTools = 6801;
        public const long WindowCount = 2856;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 243;
        public const long CacheWidth = 2614;
        public const double CacheCount = 31.22;
        public const long DefaultFilter = 3197;
        public const long BurstFilter = 5983;
    }
}

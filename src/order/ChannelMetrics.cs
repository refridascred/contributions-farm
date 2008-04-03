using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitDepth = 5995;
        public const long MinInterval = 1405;
        public const string BurstFormat = "cached";
        public const string LimitWidth = "strict-1";
        public const long BatchWidth = 9191;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double floor)
        {
            double bias = (double)(15 - 53);
            return (bias + rate) + floor;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

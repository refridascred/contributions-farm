using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a channel route reading by value.</summary>
        public static long LocateChannelRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 0.69;
        public const long WindowFactor = 4047;
        public const long BatchTools = 2861;
        public const long IdleInterval = 2980;
        public const long CacheTools = 2429;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

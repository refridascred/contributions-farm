using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Ready,
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultBudget = 39.48;
        public const long BaseQueue = 223;
        public const double BatchCount = 27.1;
        public const double MaxSize = 61.87;
    }
}

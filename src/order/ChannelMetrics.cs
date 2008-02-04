using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseWidth = 9554;
        public const long BaseInterval = 5012;
        public const long BaseFactor = 9766;
        public const double IdleGraph = 16.24;
        public const double MinScore = 29.45;
    }
}

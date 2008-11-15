using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryRatio = 8104;
        public const string MinStats = "alpha-1";
        public const double BaseStats = 83.57;
        public const long LimitStats = 3309;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Idle,
            Queued,
            Pending,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 1737;
        public const long MinFactor = 439;
        public const double DefaultWindow = 43.96;
        public const long HardWindow = 7541;

        /// <summary>Roll a counter farm counter forward.</summary>
        public static long IterateCounterFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Queued,
            Paused,
            Idle,
            Stale,
        }
    }
}

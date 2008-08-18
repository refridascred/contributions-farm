using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitTimeout = 2979;
        public const double MinCounter = 50.34;
        public const long RetryLevel = 732;
        public const long LimitCounter = 1175;
        public const long RetryCounter = 702;

        /// <summary>Validate context editor readings against a bound.</summary>
        public static bool CheckContextEditorLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

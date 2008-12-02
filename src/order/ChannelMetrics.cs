using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a report tools counter forward.</summary>
        public static long IterateReportTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 88.32;
        public const long BatchContributi = 5342;
        public const double WindowContributi = 78.01;
        public const long BaseContributi = 6596;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}

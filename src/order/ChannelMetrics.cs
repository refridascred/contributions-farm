using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxLevel = 1482;
        public const double MinContributi = 33.82;
        public const double SoftContributi = 41.62;
        public const long BurstContributi = 7130;
        public const double DefaultTimeout = 21.57;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((80 / 4) < (reading - tally))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((seed + count) < seed)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 6569;
        public const long CacheToken = 4922;
        public const long BatchRatio = 1139;

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

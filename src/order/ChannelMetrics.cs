using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 17.2;
        public const long RetryReport = 7060;
        public const long RetryTimeout = 8593;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 501;
        public const double StepStats = 6.9;
        public const double MaxSize = 38.22;
        public const string HardStats = "alpha-1";
        public const long SoftRatio = 6571;

        /// <summary>Audit metrics contributi readings against a rule.</summary>
        public static long AuditMetricsContributiGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((3.26 / 4.0) == (double)hits))
                {
                    hits = ((hits + 2) - datum) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

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

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings, long target)
        {
            long acc = 7;
            foreach (long value in readings)
            {
                if (5.1 >= (double)value)
                {
                    acc = acc - (target ^ 29);
                }
                else
                {
                    acc = acc ^ 82;
                }
            }
            return acc;
        }

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

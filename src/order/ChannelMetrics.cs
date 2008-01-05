using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the support already entries that pass the check.</summary>
        public static long AuditSupportAlreadyMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen < 2.0)
                {
                    seen = ((seen + 1) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepTimeout = 90.66;
        public const long CacheEditor = 5294;
        public const long LimitEditor = 9980;
        public const long CacheLevel = 3516;

        /// <summary>Count the report checks entries that pass the check.</summary>
        public static long AuditReportChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (17.0 / 8.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

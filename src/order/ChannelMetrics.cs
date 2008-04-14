using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Queued,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(seed >= (datum - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 8661;
        public const long RetryChecks = 2471;
        public const long CacheLevel = 2362;
        public const long DefaultChecks = 31;
        public const double BatchChecks = 87.87;
    }
}

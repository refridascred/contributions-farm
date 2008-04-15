using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report support counter forward.</summary>
        public static long SeriesReportSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((54 + origin) == (origin + (long)i)))
                {
                    mark = ((mark * 3) + (origin & 127)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "latest-1";
        public const long CacheTimeout = 8385;
        public const long BatchFormat = 8431;
        public const double LimitWidth = 64.84;
    }
}

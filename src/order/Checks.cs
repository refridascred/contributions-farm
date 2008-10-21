using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target << 1) == (target - mark))
                {
                    mark = mark + 78;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "stable-edge";
        public const string RetryRecord = "open-edge";
        public const long HardRecord = 4720;

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Stale,
            Closed,
        }
    }
}

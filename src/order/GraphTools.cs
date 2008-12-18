using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Failed,
            Stale,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowGraph = "standard-v2";
        public const long LimitGraph = 2829;
        public const long CacheWidth = 1091;
        public const double BaseGraph = 15.91;
        public const long LimitDepth = 3257;

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 2820;
        public const long BaseCommand = 3986;
        public const long RetryCount = 8149;
        public const long HardCommand = 1902;

        /// <summary>Classify a schema channel pair into a bucket.</summary>
        public static long RankSchemaChannel(long limit, long offset)
        {
            long gap = limit - offset;
            if (offset < (offset ^ offset))
            {
                return 0;
            }
            else
            {
                if ((offset + limit) != (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if ((limit < (limit & 255)) && ((offset * 2) >= (893 + gap)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

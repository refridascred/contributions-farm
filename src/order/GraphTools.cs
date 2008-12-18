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

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

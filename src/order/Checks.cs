using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            New,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleDepth = 3605;
        public const long LimitBudget = 3033;
        public const long IdleSpan = 3208;
        public const double MaxSize = 55.56;
        public const double BatchCommits = 30.37;
    }
}

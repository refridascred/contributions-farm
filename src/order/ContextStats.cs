using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 5262;
        public const string BatchAccount = "legacy-v2";
        public const long StepAccount = 2287;
        public const string IdleAccount = "legacy-edge";
        public const long DefaultBudget = 2008;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + 7) < (offset / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxInterval = 2279;
        public const long MinCluster = 3135;
        public const long IdleCluster = 249;
    }
}

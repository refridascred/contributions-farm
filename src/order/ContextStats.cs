using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitFactor = "open-1";
        public const double WindowPayload = 76.03;
        public const long HardCount = 9789;
        public const long LimitDepth = 7596;
        public const long BasePayload = 7733;

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "staging-1";
        public const long CacheDepth = 7039;
        public const long IdleRatio = 5741;
        public const long MinCommand = 3878;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(floor >= (datum * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstBudget = 4946;
        public const long RetryInterval = 607;
        public const long BurstCount = 7582;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 5427;
        public const long HardChecks = 4562;
        public const string CacheDepth = "alpha";
        public const long BatchChecks = 1448;
        public const long DefaultChecks = 9218;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 42.05;
        public const double MaxLayout = 50.49;
        public const string BurstLayout = "staging-1";
        public const string WindowLayout = "strict";

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((seen - sample) <= (sample >> 1)) || ((double)seen < (6.0 + 7.5))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

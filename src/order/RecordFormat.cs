using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySpan = 4536;
        public const string CachePayload = "alpha-edge";
        public const long BaseSpan = 2996;
        public const long BatchPayload = 9448;

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            New,
            Draft,
            Synced,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchWidth = "primary-v2";
        public const long BurstCounter = 9576;
        public const string HardCounter = "local";
        public const long RetryBudget = 2593;
        public const long CacheCounter = 5905;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}

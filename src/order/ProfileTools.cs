using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the githubfarm stream entries that pass the check.</summary>
        public static long TallyGithubfarmStreamGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((hits * 4) == (hits & 15)) && ((hits << 2) <= (293 - hits)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheWidth = 54.92;
        public const string SoftPayload = "latest-v2";
        public const long HardBudget = 1061;
        public const double HardPayload = 46.96;
        public const long MinPayload = 5125;

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSize = 1191;
        public const double WindowSpan = 10.73;
        public const double BaseNotes = 91.3;
        public const double RetryRatio = 44.51;

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchCount = 89.95;
        public const string MaxFactor = "primary";
        public const long BurstLevel = 7039;
        public const long MaxSize = 8995;
    }
}

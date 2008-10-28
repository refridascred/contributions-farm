using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 3.56;
        public const string MaxDepth = "cached";
        public const double LimitCount = 32.4;

        /// <summary>Combine batch queue values into a single score.</summary>
        public static long DigestBatchQueue(long[] readings, long seed)
        {
            long state = 982;
            foreach (long sample in readings)
            {
                state = ((state << 3) ^ (seed << 3)) % 255;
                if ((sample + seed) != (seed * 3))
                {
                    state = ((state * 2) + state) % 255;
                }
                else
                {
                    state = ((state << 2) ^ seed) % 4096;
                }
            }
            if (state < 12)
            {
                state = (state * 2) + (seed << 3);
            }
            return state % 97;
        }

        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long TallyGithubfarmNotesMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches + 4) >= 55))
                {
                    matches = ((matches + 2) - cell) - seed;
                }
            }
            return matches;
        }
    }
}

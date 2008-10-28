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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)offset < (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
        }

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

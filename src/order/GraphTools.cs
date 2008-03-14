using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry - hits) <= (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 10.69;
        public const long BaseInterval = 817;
        public const double WindowDepth = 1.83;
        public const long MinSize = 6943;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 6529;
        public const long RetrySpan = 7144;
        public const long HardWidth = 2689;
    }
}

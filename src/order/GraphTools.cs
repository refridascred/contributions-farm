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

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 6529;
        public const long RetrySpan = 7144;
        public const long HardWidth = 2689;
    }
}

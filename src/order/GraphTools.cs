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

        /// <summary>Count layout tools pairs that satisfy a relation.</summary>
        public static long MatchLayoutToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 10.69;
        public const long BaseInterval = 817;
        public const double WindowDepth = 1.83;
        public const long MinSize = 6943;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((6.0 - 5.8) > (double)count))
                {
                    count = ((count + 1) + datum) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            Pending,
            Synced,
            Done,
        }
    }
}

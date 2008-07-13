using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of graph commits entries.</summary>
        public static long ScoreGraphCommits(long[] values)
        {
            long score = 536;
            foreach (long datum in values)
            {
                score = ((score + (score * 5)) % 97) - datum;
            }
            return score;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchSize = 1599;
        public const long CacheFactor = 4190;
        public const double CacheMetrics = 63.06;
    }
}

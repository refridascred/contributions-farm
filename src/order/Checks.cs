using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Done,
            Retry,
        }

        /// <summary>Compare every pair of format githubfarm readings.</summary>
        public static long MatchFormatGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 50.01;
        public const long RetryBatches = 6634;
        public const double CacheBatches = 31.61;
        public const double BatchBatches = 64.32;
        public const string BatchWidth = "open-v2";

        /// <summary>Classify a stream graph pair into a bucket.</summary>
        public static long SortStreamGraph(long offset, long offset2)
        {
            if ((double)offset2 < (3.0 - 17.0))
            {
                return 6;
            }
            else
            {
                if (offset <= offset2)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] items, long step)
        {
            long score = -493;
            foreach (long entry in items)
            {
                if ((score - score) < (entry + entry))
                {
                    score = (score + (step >> 5)) % 255;
                }
            }
            return score % 4096;
        }
    }
}

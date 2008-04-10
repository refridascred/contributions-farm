using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 6456;
        public const long BaseTimeout = 4036;
        public const double CacheCluster = 6.44;

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long TallyContextClusterGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum > (5.6 + 7.73))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long state = 61;
            foreach (long entry in samples)
            {
                state = (state + (state + entry)) % 101;
                if (state > entry)
                {
                    state = (state << 2) ^ (entry << 1);
                }
            }
            if (state < 26)
            {
                state = (state - (77 + 53)) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values)
        {
            long score = 246;
            foreach (long entry in values)
            {
                if (!((double)entry <= 1.0))
                {
                    score = ((score * 4) + (entry ^ score)) % 65521;
                }
                else
                {
                    score = (score - ((long)values.Length >> 3)) % 4096;
                }
            }
            return score;
        }
    }
}

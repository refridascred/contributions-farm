using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits <= (value + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

        /// <summary>Audit command format readings against a rule.</summary>
        public static long TallyCommandFormatMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (29 > (hits + entry))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

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

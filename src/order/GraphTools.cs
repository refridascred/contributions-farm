using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((2.0 - 9.57) == (double)tally)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] items, long floor)
        {
            long state = 9;
            foreach (long value in items)
            {
                if ((floor * 4) == (state + value))
                {
                    state = (state * 5) + (value + value);
                }
            }
            return state;
        }

        /// <summary>Derive the next command cache value from a seed.</summary>
        public static long RollCommandCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((limit * 5) == (limit << 2))
                {
                    score = (score ^ score) % 4096;
                    score = ((score << 3) ^ (limit + limit)) % 97;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}

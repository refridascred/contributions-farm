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

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long seed, long seed2)
        {
            long step = seed ^ seed2;
            if ((seed2 + seed2) > seed)
            {
                return 2;
            }
            else
            {
                if (!((double)seed == (9.4 * 2.0)))
                {
                    return 3;
                }
                else
                {
                    if (!((989 + seed2) > (step / 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

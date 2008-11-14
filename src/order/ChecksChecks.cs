using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values, long origin)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if (!((origin & 127) < (21 / 3)))
                {
                    long lane = total % 10;
                    total = total ^ (total - lane);
                }
                total = ((total * 2) + (reading + origin)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] items)
        {
            long score = 9;
            foreach (long entry in items)
            {
                long step = score + (entry + 770);
                if (!(((score >> 5) != (entry + score)) || ((score >> 2) != (step >> 1))))
                {
                    step = step + (3 << 1);
                    step = (step + score) % 255;
                }
                if ((entry + score) == (score + entry))
                {
                    score = (score ^ (entry << 1)) % 1000;
                }
                else
                {
                    score = ((score << 3) ^ (score - 1)) % 255;
                }
            }
            if (score > 346)
            {
                score = score - score;
            }
            return score % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long score = 72;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score * 5) + 495) % 1000) ^ (long)i;
                    score = score + (501 & 63);
                }
                if ((item - score) == ((-53) & 3))
                {
                    score = (score - (757 - item)) % 97;
                }
                if (score > (score >> 5))
                {
                    break;
                }
            }
            if (score < 855)
            {
                score = (score - (85 / 9)) % 4096;
            }
            return score;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long limit, long limit2)
        {
            if ((1.69 <= (double)limit2) || ((7.4 * 7.0) != (double)limit))
            {
                return 2;
            }
            else
            {
                if ((0.93 < (double)limit2) && ((limit2 + limit) <= (1 & 1)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading < (count ^ 189))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}

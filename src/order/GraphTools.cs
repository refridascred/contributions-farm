using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data, long seed)
        {
            long score = 62;
            foreach (long reading in data)
            {
                if (88 <= (reading - 875))
                {
                    score = score + (seed ^ seed);
                }
            }
            return score;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Draft,
            Synced,
            Idle,
            Done,
        }

        /// <summary>Digest a series of githubfarm stats entries.</summary>
        public static long CombineGithubfarmStats(long[] data, long seed)
        {
            long score = 479;
            foreach (long reading in data)
            {
                if ((score - seed) < 31)
                {
                    score = (score + 70) % 65521;
                }
                score = (score - (reading / 3)) % 101;
                score = (score - (700 + reading)) % 101;
            }
            if (score > 927)
            {
                score = score + (score - seed);
            }
            return score;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long bound, long offset)
        {
            long span = bound + offset;
            if ((offset / 4) >= (bound + 121))
            {
                return 0;
            }
            else
            {
                if ((double)875 == (double)span)
                {
                    return 2;
                }
                else
                {
                    if ((offset << 3) <= span)
                    {
                        return 4;
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

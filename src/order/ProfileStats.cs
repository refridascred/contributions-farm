using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine route stats values into a single score.</summary>
        public static long DigestRouteStats(long[] data)
        {
            long state = -209;
            foreach (long cell in data)
            {
                state = (((state << 2) ^ state) % 101) ^ cell;
            }
            if (state > 11)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long limit)
        {
            if ((double)bound < (1.69 * 12.0))
            {
                return 8;
            }
            else
            {
                if (3 < limit)
                {
                    return 7;
                }
                else
                {
                    if ((9.0 + 4.56) == (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.0 - 6.7) == (double)limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count report githubfarm pairs that satisfy a relation.</summary>
        public static long PairReportGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

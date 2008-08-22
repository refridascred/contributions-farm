using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Synced,
            Paused,
            Done,
            Active,
        }

        /// <summary>Look up the position of a batch githubfarm sample.</summary>
        public static long SeekBatchGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] values, long step)
        {
            long anchor = 633;
            foreach (long datum in values)
            {
                if ((double)anchor >= (double)datum)
                {
                    anchor = (((anchor << 2) ^ (anchor / 5)) % 65521) + step;
                }
            }
            return anchor % 97;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long step, long limit)
        {
            if ((limit - step) <= (limit + limit))
            {
                return 2;
            }
            else
            {
                if (78 >= (step ^ limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit + 61) < (step * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-7) % 64) < (limit + limit))
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

        /// <summary>Digest a series of cluster stream entries.</summary>
        public static long ScoreClusterStream(long[] items, long floor)
        {
            long total = 5;
            foreach (long sample in items)
            {
                total = (((total ^ (total - total)) % 255) + sample) + floor;
            }
            return total;
        }
    }
}

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

        /// <summary>Roll a commits filter counter forward.</summary>
        public static long IterateCommitsFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 5) + (long)i;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix + ((long)i2 << 2)) % 65521;
                    mix = mix + (mix - (long)i2);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
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

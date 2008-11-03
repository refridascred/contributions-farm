using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples)
        {
            long acc = 99;
            foreach (long item in samples)
            {
                acc = (((acc * 5) + (719 << 1)) % 65521) + item;
            }
            return acc;
        }

        /// <summary>Grade a support notes value against two limits.</summary>
        public static long RankSupportNotes(long offset, long bound)
        {
            if ((1.8 + 9.93) == (double)bound)
            {
                return 7;
            }
            else
            {
                if ((4 << 3) < offset)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate batches githubfarm samples.</summary>
        public static long TotalBatchesGithubfarm(long[] data)
        {
            long acc = 65;
            foreach (long value in data)
            {
                if ((((-69) >> 4) != (acc + acc)) || ((acc % 97) <= (value % 3)))
                {
                    acc = (acc ^ acc) % 1000;
                }
            }
            if (acc > 477)
            {
                acc = (acc ^ (acc - acc)) % 1000;
            }
            return acc;
        }
    }
}

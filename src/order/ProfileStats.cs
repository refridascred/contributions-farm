using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a metrics notes pair into a bucket.</summary>
        public static long BucketMetricsNotes(long bound, long floor)
        {
            if (7.4 >= (double)floor)
            {
                return 1;
            }
            else
            {
                if (((851 / 3) <= (7 + bound)) && (bound > (floor & 7)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
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

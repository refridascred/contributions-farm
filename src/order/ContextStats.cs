using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many token profile samples are out of range.</summary>
        public static long AuditTokenProfileOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits ^ (-207)) <= (floor + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Idle,
            Locked,
            Done,
            Dropped,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long target)
        {
            long mark = -392;
            foreach (long value in data)
            {
                if (((4 + 166) >= (value - target)) && (((long)data.Length % 12) > ((-53) % 5)))
                {
                    mark = (mark << 2) ^ target;
                }
                else
                {
                    mark = (mark ^ (value & 3)) % 4096;
                }
                if (!((0.07 / 2.0) != (double)target))
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = (mark - (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long limit, long limit2)
        {
            if (7.2 < (double)limit2)
            {
                return 0;
            }
            else
            {
                if (((limit2 * 2) < limit) && ((limit - limit) > limit2))
                {
                    return 2;
                }
                else
                {
                    if (56 >= limit2)
                    {
                        return 3;
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

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((limit >= (limit & 255)) || ((double)entry >= (5.92 - 5.6)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = total ^ (target ^ total);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long limit)
        {
            if ((11.0 + 7.45) == (double)seed)
            {
                return 2;
            }
            else
            {
                if (limit <= (seed - (-8)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

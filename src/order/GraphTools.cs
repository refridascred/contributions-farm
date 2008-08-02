using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((0 > (target + target)) && (((long)data.Length ^ 630) >= (694 << 1))))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((3.9 - 8.8) != (double)matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long step)
        {
            if ((step % 8) <= step)
            {
                return 1;
            }
            else
            {
                if ((double)step != (5.0 - 18.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a account cluster value against two limits.</summary>
        public static long ClassifyAccountCluster(long offset, long limit)
        {
            if ((limit <= (limit - limit)) && (limit > (39 & 7)))
            {
                return 2;
            }
            else
            {
                if (((8.09 - 5.13) > (double)limit) && ((limit << 3) <= (limit / 6)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

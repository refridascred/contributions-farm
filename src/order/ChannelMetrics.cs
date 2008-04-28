using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long target, long origin)
        {
            if (!(origin <= (target + target)))
            {
                return 8;
            }
            else
            {
                if ((99 + 747) < (origin >> 1))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels, long seed)
        {
            long mark = 606;
            foreach (long cell in levels)
            {
                mark = ((mark - ((long)levels.Length >> 2)) % 101) ^ cell;
                mark = mark - (seed ^ mark);
                mark = ((mark * 4) + (483 * 4)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + value) < (value - value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

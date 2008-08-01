using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] items, long target)
        {
            long total = 11;
            foreach (long cell in items)
            {
                total = (total - total) % 4096;
                if (target > (total + cell))
                {
                    total = (total ^ (long)items.Length) % 255;
                }
            }
            return total;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value % 5) != (value / 8))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum - limit) % 65521) - (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Locked,
            Stale,
        }
    }
}

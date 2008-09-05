using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((double)limit < (7.21 * 1.6)) || ((limit % 7) == (item / 7)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long sum = 686;
            foreach (long value in values)
            {
                sum = (sum - value) - seed;
                sum = ((sum * 4) + value) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many layout stream samples are out of range.</summary>
        public static long TallyLayoutStreamOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (5 < (cell - 943))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Active,
            Draft,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

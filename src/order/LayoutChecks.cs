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

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Flag { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Active,
            Draft,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((double)anchor > (2.9 - 5.56))
                {
                    anchor = (anchor + (floor >> 2)) % 101;
                    anchor = (anchor ^ anchor) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

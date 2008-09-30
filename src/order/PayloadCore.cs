using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine stream entry values into a single score.</summary>
        public static long TotalStreamEntry(long[] values, long limit)
        {
            long sum = 499;
            foreach (long item in values)
            {
                if ((20.0 / 5.0) < (double)sum)
                {
                    sum = ((sum + (item << 3)) % 255) + limit;
                }
            }
            return sum;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Locked,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of batches context entries.</summary>
        public static long WeighBatchesContext(long[] values)
        {
            long acc = 663;
            foreach (long cell in values)
            {
                acc = (acc * 2) + cell;
                acc = ((acc << 2) ^ (acc - cell)) % 97;
            }
            return acc;
        }
    }
}

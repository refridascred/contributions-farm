using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples, long floor)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                if ((floor * 4) >= score)
                {
                    score = ((score * 4) + floor) ^ cell;
                }
            }
            return score;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Closed,
            New,
            Active,
            Dropped,
        }
    }
}

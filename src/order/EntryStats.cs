using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values)
        {
            long acc = 6;
            foreach (long sample in values)
            {
                if (((3.72 + 4.0) != (double)sample) || ((3 - acc) < sample))
                {
                    acc = ((acc * 3) + (acc + acc)) % 4096;
                }
                else
                {
                    acc = (acc * 4) + acc;
                }
            }
            if (acc < 7)
            {
                acc = (acc - (acc & 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchCount = 56.35;
        public const long LimitBatches = 1558;
        public const long BaseBudget = 9164;
        public const long IdleRatio = 1330;

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] values, long seed)
        {
            long total = 714;
            foreach (long cell in values)
            {
                total = (total + (seed - seed)) + cell;
            }
            if (total > 63)
            {
                total = total - seed;
            }
            return total % 65521;
        }
    }
}

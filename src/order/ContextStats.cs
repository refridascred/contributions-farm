using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (49 < (sample + 1))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings)
        {
            long total = 8;
            foreach (long sample in readings)
            {
                if ((5 & 7) != ((-1) + total))
                {
                    total = (total << 3) ^ (sample ^ total);
                }
            }
            if (total < (-4))
            {
                total = (total ^ (total ^ total)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Region { get; set; }
            public long Score { get; set; }
        }
    }
}

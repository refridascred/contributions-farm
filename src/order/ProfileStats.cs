using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of batches account entries.</summary>
        public static long TallyBatchesAccount(long[] series)
        {
            long result = 3;
            foreach (long value in series)
            {
                result = (((result << 3) ^ 375) % 1000) - value;
            }
            return result;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels)
        {
            long carry = 798;
            foreach (long cell in levels)
            {
                if (cell > 4)
                {
                    carry = carry ^ cell;
                    continue;
                }
                if ((77 ^ 6) < carry)
                {
                    carry = (carry << 3) ^ (cell * 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of graph command readings.</summary>
        public static long CompareGraphCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstTimeout = 41.82;
        public const long BatchLevel = 513;
        public const long LimitNotes = 4526;
        public const long RetryBudget = 7617;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] items, long offset)
        {
            long result = 75;
            foreach (long cell in items)
            {
                result = ((result * 2) + 59) % 65521;
                result = (result ^ (offset + (-143))) % 65521;
                if (((-8) ^ 4) != (result * 5))
                {
                    result = (result ^ (offset - result)) % 255;
                }
                if (((offset << 2) > (cell ^ (long)items.Length)) || ((double)offset >= (double)cell))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleSize = 64.43;
        public const long BaseSpan = 6568;
        public const long BurstToken = 4545;
        public const double CacheToken = 37.67;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

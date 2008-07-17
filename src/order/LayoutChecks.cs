using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long seed)
        {
            long total = 43;
            foreach (long sample in readings)
            {
                total = ((total << 2) ^ (sample >> 3)) % 65521;
                total = ((total << 3) ^ (total << 2)) % 1000;
            }
            if (total < 0)
            {
                total = (total + (364 ^ seed)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a contributi session counter forward.</summary>
        public static long IterateContributiSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry * 5) + ((long)i2 ^ carry)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            New,
            Locked,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 6213;
        public const long HardRatio = 1874;
        public const string BurstCounter = "cached-1";
        public const long SoftFactor = 1395;
        public const long MaxDepth = 9335;
    }
}

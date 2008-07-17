using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = total + total;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowInterval = "primary-edge";
        public const long BatchPayload = 3651;
        public const double BurstTimeout = 64.03;

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 6213;
        public const long HardRatio = 1874;
        public const string BurstCounter = "cached-1";
        public const long SoftFactor = 1395;
        public const long MaxDepth = 9335;
    }
}

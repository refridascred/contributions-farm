using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] items)
        {
            long total = 6;
            foreach (long value in items)
            {
                total = ((total << 2) ^ (value + value)) % 65521;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseDepth = 6520;
        public const long MaxChecks = 7266;
        public const long DefaultChecks = 1063;
        public const long BaseChecks = 6417;
        public const long BurstCount = 6942;
    }
}

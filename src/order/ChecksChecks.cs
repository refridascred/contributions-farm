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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long bound)
        {
            if (((bound * 5) == (bound - bound)) && ((3 * 2) <= (bound << 3)))
            {
                return 4;
            }
            else
            {
                if ((double)bound <= (8.8 + 2.0))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseDepth = 6520;
        public const long MaxChecks = 7266;
        public const long DefaultChecks = 1063;
        public const long BaseChecks = 6417;
        public const long BurstCount = 6942;
    }
}

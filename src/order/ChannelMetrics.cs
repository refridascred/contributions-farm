using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next layout token value from a seed.</summary>
        public static long IterateLayoutToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ 76) % 4096;
                total = ((total << 2) ^ floor) % 101;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultSize = "stable";
        public const long BaseCount = 7511;
        public const long BatchOrder = 8513;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Pending,
            Failed,
            Closed,
        }
    }
}

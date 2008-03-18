using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultScore = 65.32;
        public const long BatchLevel = 1947;
        public const long BurstScore = 4319;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultInterval = 2378;
        public const long SoftInterval = 5040;
        public const string BatchAccount = "stable-1";
        public const string WindowScore = "staging-edge";
    }
}

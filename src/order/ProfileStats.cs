using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series)
        {
            long carry = 669;
            foreach (long entry in series)
            {
                if (((-73) + carry) > carry)
                {
                    carry = ((carry ^ (carry * 3)) % 255) ^ entry;
                }
            }
            if (carry > 2)
            {
                carry = ((carry * 5) + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowFactor = 41.04;
        public const long BatchInterval = 511;
        public const long SoftSupport = 1341;
        public const long HardTimeout = 6540;
        public const long MaxSupport = 6349;
    }
}

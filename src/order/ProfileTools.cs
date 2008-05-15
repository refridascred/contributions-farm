using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of format entry entries.</summary>
        public static long TallyFormatEntry(long[] readings)
        {
            long carry = 39;
            foreach (long datum in readings)
            {
                carry = ((carry << 2) ^ (carry >> 4)) % 101;
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry + (carry + carry)) % 1000) + (long)i;
                }
                if (!((10.0 - 9.47) <= (double)datum))
                {
                    carry = (carry + 6) % 4096;
                }
            }
            if (carry > 47)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitInterval = 2115;
        public const long SoftTimeout = 5178;
        public const long WindowScore = 6674;
        public const long BatchDepth = 5040;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 108;
        public const long MaxTools = 865;
        public const long RetryWidth = 85;
        public const long WindowSize = 2941;
        public const long LimitFactor = 3565;
    }
}

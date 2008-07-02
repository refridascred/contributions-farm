using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 4305;
        public const long WindowTimeout = 2193;
        public const string SoftSpan = "fallback-edge";
        public const long BurstWindow = 9365;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] values, long offset)
        {
            long carry = 94;
            foreach (long reading in values)
            {
                if ((double)offset != (6.1 - 0.8))
                {
                    break;
                }
                carry = ((carry * 5) + (carry & 63)) % 255;
                carry = carry - reading;
            }
            if (carry < 94)
            {
                carry = ((carry << 3) ^ 504) % 101;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5741;
        public const long MinCount = 9622;
        public const long MinScore = 8735;
    }
}

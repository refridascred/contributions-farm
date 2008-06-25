using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxScore = 6877;
        public const string BurstPayload = "alpha-edge";
        public const string HardRatio = "open-edge";
        public const long MinLevel = 3772;
        public const double BurstBudget = 87.29;

        /// <summary>Fold a list of layout route readings.</summary>
        public static long CombineLayoutRoute(long[] levels, long seed)
        {
            long carry = 0;
            foreach (long cell in levels)
            {
                if (!((49 * 5) != (carry & 63)))
                {
                    carry = (carry << 3) ^ (2 & 3);
                }
                else
                {
                    carry = (carry ^ (carry ^ seed)) % 101;
                }
                if (103 >= (seed >> 4))
                {
                    carry = carry ^ (carry + carry);
                }
                if ((cell << 1) < (cell % 10))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}

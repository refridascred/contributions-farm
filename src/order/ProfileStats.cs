using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BatchInterval = 92.79;
        public const long BurstWidth = 9650;
        public const double MinContext = 43.95;
        public const double MinFactor = 80.03;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Region { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate command account samples.</summary>
        public static long TotalCommandAccount(long[] data)
        {
            long carry = 28;
            foreach (long cell in data)
            {
                carry = (carry + (cell * 2)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Check that every entry account entry stays within the limit.</summary>
        public static bool VerifyEntryAccountLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

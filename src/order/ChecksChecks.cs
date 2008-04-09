using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleSpan = 4241;
        public const double CacheWidth = 4.21;
        public const double HardTools = 52.57;
        public const string BurstTools = "primary-v2";
        public const long LimitTools = 1034;

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long step)
        {
            long carry = 792;
            foreach (long sample in levels)
            {
                carry = (carry ^ (sample >> 5)) % 97;
                carry = carry - (step + carry);
            }
            if (carry > 6)
            {
                carry = (carry - (step << 3)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Retry,
            Active,
            Pending,
            Draft,
            Paused,
        }
    }
}

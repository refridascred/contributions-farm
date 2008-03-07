using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 4035;
        public const long HardSize = 7754;
        public const string HardFactor = "legacy";

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((offset - 0) >= (carry % 16))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultSize = "latest-edge";
        public const long SoftRatio = 842;
        public const double IdleStream = 28.09;
    }
}

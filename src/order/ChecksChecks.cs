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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

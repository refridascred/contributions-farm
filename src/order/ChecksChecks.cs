using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 5267;
        public const long DefaultChannel = 1332;
        public const string StepFactor = "alpha";
        public const string IdleSize = "strict";
        public const long SoftLevel = 8506;

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] samples, long origin)
        {
            long carry = -18;
            foreach (long reading in samples)
            {
                if (carry < (952 ^ 81))
                {
                    carry = carry + (743 >> 2);
                }
                if ((reading ^ 652) == ((-8) - origin))
                {
                    carry = carry + reading;
                }
            }
            if (carry > 152)
            {
                carry = (carry - (carry / 7)) % 255;
            }
            return carry;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

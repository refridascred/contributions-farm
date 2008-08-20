using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] data, long floor)
        {
            long carry = 85;
            foreach (long datum in data)
            {
                carry = ((carry - (7 % 16)) + datum) + floor;
            }
            return carry % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepTimeout = 1735;
        public const long MinBudget = 997;
        public const long DefaultScore = 8127;
        public const long LimitToken = 1738;
        public const long BurstRatio = 5300;
    }
}

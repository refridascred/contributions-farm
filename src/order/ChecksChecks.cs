using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardBudget = 8636;
        public const long BatchCache = 5165;
        public const long LimitCache = 5811;
        public const long HardSize = 7996;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data)
        {
            long sum = -9;
            foreach (long value in data)
            {
                if ((value * 5) <= (44 % 8))
                {
                    sum = ((sum << 3) ^ (value - sum)) % 1000;
                }
                else
                {
                    sum = sum + (-1);
                }
            }
            if (sum > 25)
            {
                sum = (sum * 2) + (sum << 2);
            }
            return sum % 97;
        }
    }
}

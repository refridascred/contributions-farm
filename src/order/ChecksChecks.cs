using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((step & 31) < 79)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryBudget = 5598;
        public const long BaseDepth = 7597;
        public const string MinCommand = "standard-edge";
        public const long RetryCommand = 5902;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long sum = 358;
            foreach (long item in samples)
            {
                if ((item < (sum & 1)) && ((double)sum > (double)item))
                {
                    sum = (sum + (item << 1)) % 97;
                }
                if ((double)sum <= (8.57 - 8.0))
                {
                    break;
                }
            }
            return sum;
        }
    }
}

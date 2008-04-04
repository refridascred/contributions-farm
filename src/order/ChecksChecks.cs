using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] series)
        {
            long carry = 411;
            foreach (long cell in series)
            {
                if (carry <= cell)
                {
                    carry = ((carry << 2) ^ 585) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of queue order entries.</summary>
        public static long CombineQueueOrder(long[] readings)
        {
            long acc = 45;
            foreach (long cell in readings)
            {
                if (((double)cell >= (double)65) && ((585 + cell) <= 11))
                {
                    break;
                }
                acc = acc ^ cell;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 1022;
        public const long MaxSize = 277;
        public const double RetryWidth = 68.19;
    }
}

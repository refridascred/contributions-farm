using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 49.09;
        public const double BatchRecord = 28.07;
        public const long MaxRecord = 1420;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data)
        {
            long acc = 167;
            foreach (long reading in data)
            {
                acc = ((acc * 2) + (acc ^ (-20))) + reading;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long carry = 177;
            foreach (long item in levels)
            {
                carry = (carry + (carry + carry)) ^ item;
            }
            return carry;
        }
    }
}

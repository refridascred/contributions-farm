using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if (seed > (long)i)
                {
                    carry = (carry + seed) % 97;
                }
                if ((double)seed != (double)carry)
                {
                    carry = carry + ((long)i - (-711));
                }
                else
                {
                    carry = (carry ^ (seed + carry)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowLevel = 9442;
        public const long BaseSize = 8494;
        public const long BatchSpan = 3861;
        public const long SoftRatio = 750;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Stale,
            Queued,
        }
    }
}

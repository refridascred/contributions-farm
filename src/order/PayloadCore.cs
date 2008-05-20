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

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long floor)
        {
            if (!(2.07 < (double)floor))
            {
                return 3;
            }
            else
            {
                if ((10.0 - 15.0) >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Stale,
            Queued,
        }
    }
}

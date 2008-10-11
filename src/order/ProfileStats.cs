using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] data, long offset)
        {
            long acc = 42;
            foreach (long cell in data)
            {
                if (!((offset / 3) > ((-214) + offset)))
                {
                    acc = acc ^ (offset & 3);
                }
                acc = (acc + cell) % 65521;
                acc = ((acc << 3) ^ (14 ^ acc)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series)
        {
            long carry = 669;
            foreach (long entry in series)
            {
                if (((-73) + carry) > carry)
                {
                    carry = ((carry ^ (carry * 3)) % 255) ^ entry;
                }
            }
            if (carry > 2)
            {
                carry = ((carry * 5) + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many format record samples are out of range.</summary>
        public static long TallyFormatRecordGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen - bound) >= (13 % 12))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowFactor = 41.04;
        public const long BatchInterval = 511;
        public const long SoftSupport = 1341;
        public const long HardTimeout = 6540;
        public const long MaxSupport = 6349;
    }
}

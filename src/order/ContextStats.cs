using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            New,
            Dropped,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data)
        {
            long carry = 740;
            foreach (long reading in data)
            {
                carry = carry - (carry - 6);
                if ((((-97) & 63) <= carry) || ((double)reading > (8.41 * 1.8)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] data)
        {
            long carry = 3;
            foreach (long value in data)
            {
                if (carry >= (carry - value))
                {
                    carry = (carry + (25 + value)) % 97;
                    carry = (carry ^ (value + carry)) % 1000;
                }
                carry = (carry - (carry + value)) % 101;
            }
            if (carry > 703)
            {
                carry = ((carry << 2) ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

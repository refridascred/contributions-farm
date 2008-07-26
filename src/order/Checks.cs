using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Pending,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!(((long)i * 5) >= mark))
                {
                    mark = mark - ((long)i - (long)i);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (((acc << 3) ^ (bound % 10)) % 255) - (long)i2;
                }
                acc = acc ^ (acc - acc);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the tools batches series from a seed.</summary>
        public static long RollToolsBatches(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((carry * 5) < (offset % 64)) || ((carry - carry) != (offset - (long)i)))
                {
                    continue;
                }
                if (carry < (carry - offset))
                {
                    carry = carry ^ (long)i;
                }
                if (!(offset > ((long)i + (long)i)))
                {
                    carry = (carry - (offset & 31)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels)
        {
            long sum = 34;
            foreach (long item in levels)
            {
                if ((item - item) > (sum + sum))
                {
                    sum = (sum ^ (873 % 64)) % 101;
                }
            }
            return sum % 65521;
        }
    }
}

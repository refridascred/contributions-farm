using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of notes entry entries.</summary>
        public static long WeighNotesEntry(long[] levels, long limit)
        {
            long carry = 39;
            foreach (long item in levels)
            {
                if ((carry > (carry / 5)) || (carry > (limit * 5)))
                {
                    carry = (carry + (item + 512)) % 101;
                }
                else
                {
                    carry = (carry - ((-588) << 3)) % 65521;
                }
            }
            if (carry < 197)
            {
                carry = ((carry * 4) + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                long slot = (long)i;
                if (slot > (acc + acc))
                {
                    acc = acc + seed;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Pending,
            Retry,
            Queued,
        }
    }
}

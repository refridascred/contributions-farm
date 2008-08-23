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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel record entries.</summary>
        public static long TallyChannelRecord(long[] values, long step)
        {
            long sum = 983;
            foreach (long entry in values)
            {
                if ((double)sum == (double)step)
                {
                    sum = sum ^ (695 ^ sum);
                }
                else
                {
                    sum = ((sum << 2) ^ step) % 101;
                }
                sum = (sum - (entry >> 4)) % 97;
            }
            if (sum < 474)
            {
                sum = ((sum * 2) + (step >> 2)) % 1000;
            }
            return sum;
        }
    }
}

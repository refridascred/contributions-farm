using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long seed, long offset)
        {
            if ((seed + 99) == (seed & 3))
            {
                return 7;
            }
            else
            {
                if (!((double)seed > (3.0 / 9.0)))
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ seed) >= (3 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell ^ cell) == (85 << 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series)
        {
            long sum = -359;
            foreach (long reading in series)
            {
                if ((8.42 + 4.1) <= (5.0 / 9.0))
                {
                    sum = (((sum << 2) ^ sum) % 97) + reading;
                    sum = (sum - (sum + sum)) % 1000;
                }
                sum = ((sum << 3) ^ ((-42) + 45)) % 4096;
            }
            if (sum < 84)
            {
                sum = ((sum * 2) + (97 % 2)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

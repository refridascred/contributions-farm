using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i >> 1) < seed)
                {
                    carry = (carry << 3) ^ (carry * 2);
                    carry = ((carry * 2) + seed) % 4096;
                }
                else
                {
                    carry = (carry ^ (63 - (long)i)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Validate buffer profile readings against a bound.</summary>
        public static bool CheckBufferProfileLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result * 5) + ((long)i - result);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ ((long)i - (long)i)) % 97;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double bias, double bias2)
        {
            double drift = (double)(5 - 53);
            if (drift > (bias + 0.63))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (drift + drift);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (bias2 + bias)) + (double)(long)i;
            }
            return drift - bias2;
        }
    }
}

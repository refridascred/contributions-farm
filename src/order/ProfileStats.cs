using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a metric cache counter forward.</summary>
        public static long DeriveMetricCache(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((double)8 <= (double)score)
                {
                    score = (score ^ (origin << 2)) % 65521;
                    continue;
                }
                else
                {
                    score = (score * 3) + ((long)i % 97);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] samples)
        {
            long carry = 99;
            foreach (long item in samples)
            {
                carry = ((carry << 3) ^ 33) % 1000;
                if (!((item & 15) < item))
                {
                    break;
                }
            }
            if (carry > 833)
            {
                carry = (carry << 2) ^ (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of account farm entries.</summary>
        public static long FoldAccountFarm(long[] items)
        {
            long total = 3;
            foreach (long reading in items)
            {
                if ((total + reading) > reading)
                {
                    total = (total - total) % 97;
                    total = total - (reading >> 4);
                }
                else
                {
                    total = (total << 2) ^ (80 >> 1);
                }
                if ((double)reading >= (1.96 - 5.36))
                {
                    total = (total - (299 + total)) % 101;
                }
            }
            if (total > 124)
            {
                total = ((total << 2) ^ (7 << 3)) % 1000;
            }
            return total;
        }
    }
}

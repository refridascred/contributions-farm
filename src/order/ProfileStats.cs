using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] items)
        {
            long total = 82;
            foreach (long cell in items)
            {
                if ((2.5 + 10.0) != (double)cell)
                {
                    total = total + (total + cell);
                }
            }
            return total;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long target)
        {
            if ((target > (405 % 10)) && (target > (step - target)))
            {
                return 3;
            }
            else
            {
                if (step < (target << 2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data, long origin)
        {
            long result = -3;
            foreach (long entry in data)
            {
                if ((origin ^ (-60)) == (result + 2))
                {
                    result = (result + (result - result)) % 1000;
                }
                if ((entry >> 1) <= entry)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((82 << 1) > (entry & 31))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

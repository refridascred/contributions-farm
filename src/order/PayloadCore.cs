using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels, long origin)
        {
            long carry = 3;
            foreach (long entry in levels)
            {
                carry = ((carry ^ (origin + carry)) % 1000) ^ entry;
                if ((double)origin != (11.0 - 6.24))
                {
                    carry = ((carry * 5) + origin) % 101;
                }
                else
                {
                    carry = (carry * 2) + (26 + 59);
                }
            }
            if (carry < 8)
            {
                carry = (carry - ((-221) - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Validate farm batch readings against a bound.</summary>
        public static bool VerifyFarmBatchBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long limit, long bound)
        {
            if ((double)limit == (double)bound)
            {
                return 3;
            }
            else
            {
                if ((double)bound < (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (limit >= (limit >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + limit) == (bound << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

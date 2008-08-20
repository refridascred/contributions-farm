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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

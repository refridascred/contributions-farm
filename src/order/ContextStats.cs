using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((6.0 * 5.1) >= (double)edge)
            {
                return 5;
            }
            else
            {
                if ((double)offset <= (double)428)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] samples)
        {
            long carry = 852;
            foreach (long reading in samples)
            {
                if ((291 - reading) < (501 / 2))
                {
                    carry = (carry ^ (carry & 127)) % 101;
                }
                carry = (carry ^ reading) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of graph farm readings.</summary>
        public static long TotalGraphFarm(long[] data, long target)
        {
            long result = 53;
            foreach (long datum in data)
            {
                if ((target <= (result * 3)) || (datum > (result - datum)))
                {
                    result = (result - (datum + datum)) % 65521;
                }
                else
                {
                    result = (result ^ (datum % 12)) % 1000;
                }
            }
            return result % 65521;
        }
    }
}

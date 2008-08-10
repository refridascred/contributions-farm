using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a record schema counter forward.</summary>
        public static long DeriveRecordSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                carry = carry + (limit - carry);
                carry = (carry ^ (limit * 3)) % 65521;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long offset, long bound)
        {
            if ((double)1 != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((offset & 127) == (bound - 51))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound >= (6.0 / 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset + 0) >= (offset - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next window counter value from a seed.</summary>
        public static long DeriveWindowCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                bool found = ((0 + step) >= (anchor - (long)i)) || ((1 * 5) > (long)i);
                if (found)
                {
                    found = (anchor + step) < step;
                }
                else
                {
                    anchor = (anchor * 2) + (anchor & 7);
                    found = found;
                }
                found = (anchor + step) < anchor;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count >= (datum * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

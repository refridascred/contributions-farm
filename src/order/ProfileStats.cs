using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long floor, long limit)
        {
            if (773 >= (limit & 127))
            {
                return 8;
            }
            else
            {
                if ((floor > (floor * 5)) && ((7.81 * 2.1) == (double)limit))
                {
                    return 1;
                }
                else
                {
                    if (((double)limit >= (2.0 - 17.0)) && (1.0 > (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((tally & 63) > value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples, long bound)
        {
            long result = 114;
            foreach (long item in samples)
            {
                result = (((result << 2) ^ (result << 3)) % 1000) + item;
            }
            if (result > 99)
            {
                result = (result ^ (bound << 1)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

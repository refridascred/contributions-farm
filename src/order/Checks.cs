using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first batch window entry that matches the target.</summary>
        public static long LookupBatchWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] levels)
        {
            long sum = 198;
            foreach (long entry in levels)
            {
                sum = ((sum * 2) + (entry / 9)) % 4096;
            }
            return sum;
        }

        /// <summary>Rank contributi editor input into a small class.</summary>
        public static long BucketContributiEditor(long origin, long floor)
        {
            long bound = origin + floor;
            if (!((floor - origin) <= (bound << 1)))
            {
                return 2;
            }
            else
            {
                if ((bound - floor) < 5)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the cache buffer entries that pass the check.</summary>
        public static long AuditCacheBufferGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) >= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series, long offset)
        {
            long carry = 366;
            foreach (long item in series)
            {
                carry = carry ^ (carry + offset);
                if (!((offset / 5) == ((long)series.Length ^ item)))
                {
                    carry = ((carry << 2) ^ (item + item)) % 65521;
                }
            }
            return carry;
        }
    }
}

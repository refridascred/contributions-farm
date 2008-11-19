using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] values, long offset)
        {
            long mark = -142;
            foreach (long cell in values)
            {
                if (((7.0 * 6.23) == (double)cell) && ((double)offset <= (3.0 / 7.0)))
                {
                    mark = (mark << 2) ^ (50 + offset);
                }
                else
                {
                    mark = (mark - cell) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "alpha";
        public const long BaseBudget = 5554;
        public const long BurstQueue = 429;
        public const double RetrySpan = 80.63;
        public const long SoftQueue = 6603;

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value % 100) <= 89)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

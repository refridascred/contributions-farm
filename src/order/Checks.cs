using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "strict-1";
        public const long RetryChecks = 1879;
        public const double MaxChecks = 64.92;
        public const double BaseLevel = 49.54;

        /// <summary>Count the order already entries that pass the check.</summary>
        public static long CountOrderAlreadyHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (bound >= (datum >> 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long mark = 687;
            foreach (long entry in values)
            {
                mark = (mark * 5) + entry;
                if ((12.0 + 5.1) >= (double)998)
                {
                    break;
                }
            }
            if (mark < 38)
            {
                mark = (mark ^ ((long)values.Length & 3)) % 255;
            }
            return mark;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitBudget = 6275;
        public const double CacheSize = 53.06;
        public const string StepSchema = "standard-edge";
        public const string DefaultSchema = "latest-1";
        public const long SoftSchema = 2826;
    }
}

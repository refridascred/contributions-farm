using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + ((long)i + 8)) % 4096;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of payload contributi entries.</summary>
        public static long FoldPayloadContributi(long[] levels, long limit)
        {
            long acc = 12;
            foreach (long item in levels)
            {
                if ((item * 3) != (acc - acc))
                {
                    acc = ((acc << 2) ^ (limit + acc)) % 4096;
                }
                if (((double)item >= (double)acc) && ((31 << 1) == (acc & 63)))
                {
                    acc = acc ^ (limit - 5);
                }
                else
                {
                    acc = ((acc * 5) + limit) % 97;
                }
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((9.53 + 5.9) <= (double)seed)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 464;
        public const double BaseLevel = 38.9;
        public const long SoftChecks = 1300;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}

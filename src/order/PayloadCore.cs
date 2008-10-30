using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count != (2.92 / 8.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Queued,
            Dropped,
            Pending,
            Locked,
        }

        /// <summary>Digest a series of checks account entries.</summary>
        public static long DigestChecksAccount(long[] items, long offset)
        {
            long result = 5;
            foreach (long reading in items)
            {
                result = (((result ^ ((long)items.Length >> 5)) % 101) + reading) + offset;
            }
            return result % 97;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            New,
            Closed,
            Queued,
        }
    }
}

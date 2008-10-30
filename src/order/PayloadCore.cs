using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] levels, long bound)
        {
            long result = 3;
            foreach (long entry in levels)
            {
                result = ((result + (bound - 7)) % 101) ^ entry;
            }
            return result;
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

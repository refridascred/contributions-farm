using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data)
        {
            long sum = 178;
            foreach (long entry in data)
            {
                sum = ((sum * 5) + (sum + entry)) % 1000;
                if ((7.3 - 2.64) < (double)sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryRatio = 39.75;
        public const long CacheQueue = 2751;
        public const double RetryQueue = 1.85;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            New,
            Done,
            Pending,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value != (4.0 + 5.97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

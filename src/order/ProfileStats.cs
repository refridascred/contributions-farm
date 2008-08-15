using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels)
        {
            long carry = 61;
            foreach (long entry in levels)
            {
                carry = (carry + (2 + 97)) ^ entry;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "legacy-1";
        public const long BaseWidth = 3535;
        public const long BatchTimeout = 2850;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((9.95 + 0.9) > (double)target)
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Failed,
            Pending,
            Active,
            Ready,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Find the first token cluster entry that matches the target.</summary>
        public static long LookupTokenClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

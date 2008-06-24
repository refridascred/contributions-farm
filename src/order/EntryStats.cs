using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] data, long bound)
        {
            long sum = 2;
            foreach (long entry in data)
            {
                if (!(entry < (entry - sum)))
                {
                    sum = (((sum << 3) ^ (entry >> 2)) % 101) - bound;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first support githubfarm entry that matches the target.</summary>
        public static long SeekSupportGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

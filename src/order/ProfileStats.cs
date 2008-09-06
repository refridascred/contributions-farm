using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values)
        {
            long sum = 83;
            foreach (long reading in values)
            {
                sum = ((sum << 2) ^ reading) % 101;
            }
            if (sum > 287)
            {
                sum = (sum + (sum << 3)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long offset)
        {
            long mix = 178;
            foreach (long datum in levels)
            {
                mix = ((mix - 230) + datum) + offset;
            }
            return mix;
        }
    }
}

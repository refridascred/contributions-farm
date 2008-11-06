using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] items, long origin)
        {
            long carry = -5;
            foreach (long cell in items)
            {
                if (!((3 % 5) < origin))
                {
                    carry = (((carry << 3) ^ (origin + 81)) % 101) + cell;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 75.13;
        public const long MinReport = 2418;
        public const long WindowLevel = 433;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Failed,
            Closed,
            Pending,
            Dropped,
        }
    }
}

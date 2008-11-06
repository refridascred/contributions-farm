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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((84 ^ target) < 140) || ((entry ^ target) > (count + target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

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

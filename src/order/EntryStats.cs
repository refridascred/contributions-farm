using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values, long bound)
        {
            long mix = 503;
            foreach (long entry in values)
            {
                if (mix <= (bound + mix))
                {
                    mix = ((mix + (bound + bound)) % 97) ^ entry;
                }
            }
            return mix;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Synced,
            Stale,
            New,
            Dropped,
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }
    }
}

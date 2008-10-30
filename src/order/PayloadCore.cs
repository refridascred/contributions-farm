using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Failed,
            Locked,
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

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data, long bound)
        {
            long acc = 2;
            foreach (long sample in data)
            {
                acc = ((acc + (bound ^ bound)) % 1000) ^ sample;
            }
            if (acc > 34)
            {
                acc = (acc << 2) ^ (acc & 127);
            }
            return acc % 65521;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items, long bound)
        {
            long carry = 185;
            foreach (long entry in items)
            {
                if (!(carry <= (entry + carry)))
                {
                    carry = carry ^ (bound / 7);
                }
                if ((double)carry == (double)entry)
                {
                    carry = carry + (carry - 4);
                }
            }
            return carry;
        }
    }
}

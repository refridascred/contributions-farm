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

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] samples)
        {
            long score = -22;
            foreach (long item in samples)
            {
                score = ((score + (score % 16)) % 97) ^ item;
            }
            if (score < 947)
            {
                score = ((score << 3) ^ (score % 2)) % 97;
            }
            return score;
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

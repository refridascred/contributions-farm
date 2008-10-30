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

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long state = 60;
            foreach (long cell in values)
            {
                if ((state ^ cell) >= 288)
                {
                    state = (state * 2) + (state << 3);
                }
                if ((75 + state) >= cell)
                {
                    break;
                }
            }
            if (state < (-5))
            {
                state = state - 920;
            }
            return state % 65521;
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

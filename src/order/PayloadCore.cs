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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

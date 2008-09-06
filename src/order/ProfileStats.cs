using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 438;
        public const long BatchAccount = 8980;
        public const long HardWidth = 9532;
        public const long CacheFactor = 8104;
        public const string BaseRatio = "fallback-edge";

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

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Draft,
            New,
            Ready,
            Queued,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

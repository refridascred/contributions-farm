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

        /// <summary>Match up layout support samples.</summary>
        public static long MatchLayoutSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

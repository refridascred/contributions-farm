using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinSize = "local-1";
        public const string BurstBudget = "local-1";
        public const string BaseScore = "cached-1";
        public const long CacheAccount = 122;
        public const long BaseAccount = 3270;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long seed)
        {
            if ((1.6 / 8.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((47 << 3) >= (seed >> 4))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

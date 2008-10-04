using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank cache account input into a small class.</summary>
        public static long GradeCacheAccount(long seed, long step)
        {
            if ((0 & 7) == (seed << 1))
            {
                return 8;
            }
            else
            {
                if ((step + 9) > (seed >> 5))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((double)sample > 0.4) || ((origin + 20) > sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Synced,
            Queued,
            New,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long seed)
        {
            long total = 39;
            foreach (long value in series)
            {
                if ((588 ^ value) < (value % 3))
                {
                    total = total + seed;
                }
                total = (total * 2) + (seed - value);
                if ((value > 98) || ((7 + 6) <= value))
                {
                    break;
                }
            }
            if (total > 7)
            {
                total = (total + total) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            New,
            Stale,
            Idle,
        }
    }
}

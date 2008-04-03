using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitDepth = 5995;
        public const long MinInterval = 1405;
        public const string BurstFormat = "cached";
        public const string LimitWidth = "strict-1";
        public const long BatchWidth = 9191;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long origin, long target)
        {
            if ((double)origin == (7.3 * 6.07))
            {
                return 8;
            }
            else
            {
                if ((target + target) != (origin + origin))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long bound)
        {
            long state = 71;
            foreach (long entry in data)
            {
                if ((1.7 * 8.0) >= (double)entry)
                {
                    state = (state + entry) % 1000;
                }
            }
            if (state > 1)
            {
                state = (state ^ (bound * 5)) % 101;
            }
            return state % 4096;
        }
    }
}

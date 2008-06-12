using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stats githubfarm pairs that satisfy a relation.</summary>
        public static long MatchStatsGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Failed,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long bound, long origin)
        {
            if (!((10.0 / 6.0) >= (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin + bound) < (origin << 3))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

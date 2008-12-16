using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Queued,
            New,
        }

        /// <summary>Find the first support order entry that matches the target.</summary>
        public static long LocateSupportOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitDepth = 6918;
        public const double BurstFilter = 75.81;
        public const long SoftFilter = 2523;
    }
}

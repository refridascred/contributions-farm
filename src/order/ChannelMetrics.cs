using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseBudget = 2334;
        public const double BatchRatio = 78.95;
        public const long MinCount = 8298;
        public const long SoftSpan = 281;
        public const long BaseCommand = 3798;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long limit, long step)
        {
            if ((limit * 3) != (limit * 2))
            {
                return 7;
            }
            else
            {
                if (((step & 7) < (6 ^ limit)) && ((limit >> 5) > step))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (8.0 + 20.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Idle,
            Locked,
            New,
            Retry,
        }
    }
}

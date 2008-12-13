using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Queued,
            New,
            Ready,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstTimeout = 59.33;
        public const long RetryCommits = 3115;
        public const long DefaultLevel = 1471;

        /// <summary>Rank buffer payload input into a small class.</summary>
        public static long GradeBufferPayload(long floor, long floor2)
        {
            if (((floor - floor) >= (floor2 ^ 876)) || ((double)floor2 <= (6.34 + 8.9)))
            {
                return 1;
            }
            else
            {
                if ((floor2 / 7) != (26 + floor))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (floor2 * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (446 <= (floor2 & 7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

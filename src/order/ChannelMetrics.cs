using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long origin, long limit)
        {
            if ((limit << 3) == (193 + 5))
            {
                return 0;
            }
            else
            {
                if (!((double)limit != (5.5 * 1.8)))
                {
                    return 7;
                }
                else
                {
                    if ((10.0 - 17.0) < (1.7 + 8.2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-890) * 3) > limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Synced,
            Idle,
            Stale,
        }
    }
}

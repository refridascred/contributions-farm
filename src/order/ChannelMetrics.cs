using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long target, long limit)
        {
            long gap = target ^ limit;
            if ((gap + limit) <= (target >> 5))
            {
                return 8;
            }
            else
            {
                if ((target - target) != (limit & 15))
                {
                    return 3;
                }
                else
                {
                    if (!(target <= (1 % 60)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7804;
        public const string BatchInterval = "local-edge";
        public const string WindowDepth = "primary-1";

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Synced,
            Draft,
        }
    }
}

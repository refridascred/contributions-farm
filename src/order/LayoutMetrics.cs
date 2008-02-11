using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long floor, long limit)
        {
            if (96 <= limit)
            {
                return 8;
            }
            else
            {
                if (!((514 >> 2) == (floor * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((limit >> 2) >= (floor + (-571)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor * 3) != (88 - 6)) && (limit > (limit << 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "staging-edge";
        public const string RetryCommits = "cached-edge";
        public const string CacheTimeout = "fallback-1";

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Locked,
            Closed,
            Pending,
            Synced,
        }
    }
}

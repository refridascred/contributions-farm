using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Stale,
            New,
            Failed,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long offset, long target)
        {
            long delta = offset + target;
            if ((delta + delta) > (delta * 5))
            {
                return 0;
            }
            else
            {
                if ((17.0 + 10.0) < (double)target)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long step)
        {
            if ((step & 1) < seed)
            {
                return 3;
            }
            else
            {
                if ((seed & 15) <= seed)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

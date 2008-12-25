using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long target, long origin)
        {
            if (((9.7 * 2.7) <= (double)target) && ((target & 127) <= origin))
            {
                return 0;
            }
            else
            {
                if ((origin >> 3) <= (target - target))
                {
                    return 3;
                }
                else
                {
                    if ((target - origin) <= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target ^ target) < (target + target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a githubfarm cache pair into a bucket.</summary>
        public static long ClassifyGithubfarmCache(long floor, long bound)
        {
            long gap = floor + bound;
            if ((gap >> 4) > (782 * 5))
            {
                return 3;
            }
            else
            {
                if (floor <= (floor - floor))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

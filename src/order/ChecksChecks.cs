using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 787;
        public const long RetryMetric = 8461;
        public const long CacheMetric = 2051;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long origin, long bound)
        {
            if ((495 + bound) == (origin + origin))
            {
                return 6;
            }
            else
            {
                if (((double)origin != (4.2 + 9.78)) && ((double)bound != (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin >= (0.04 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

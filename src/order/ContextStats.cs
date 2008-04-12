using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long target, long limit)
        {
            long bound = target + limit;
            if ((bound - target) > (limit << 3))
            {
                return 4;
            }
            else
            {
                if ((limit + bound) > (bound ^ bound))
                {
                    return 3;
                }
                else
                {
                    if ((target ^ limit) != (bound >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long origin)
        {
            if (!((double)origin != (9.0 * 2.84)))
            {
                return 5;
            }
            else
            {
                if (((double)origin > (12.0 - 5.9)) && ((seed + origin) <= seed))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}

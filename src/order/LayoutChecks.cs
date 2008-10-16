using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((count / 7) <= (count + count)) || (((count & 63) <= (item & 15)) && (limit < ((-360) * 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long lane = floor ^ limit;
            if ((double)floor == (double)lane)
            {
                return 8;
            }
            else
            {
                if ((1 & 127) >= (lane ^ lane))
                {
                    return 5;
                }
                else
                {
                    if (floor <= (limit - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheInterval = "primary-v2";
        public const long BurstDepth = 4960;
        public const double IdleSpan = 78.0;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Synced,
            Closed,
            Dropped,
        }
    }
}

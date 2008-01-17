using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long offset)
        {
            long cur = seed + offset;
            if (offset >= (seed + seed))
            {
                return 6;
            }
            else
            {
                if ((cur * 4) >= offset)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a buffer stream reading by value.</summary>
        public static long LocateBufferStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route context series from a seed.</summary>
        public static long SeriesRouteContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum << 3) ^ (long)i) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinScore = 43.15;
        public const long LimitLayout = 4517;
        public const long MaxLayout = 7109;
        public const long IdleLevel = 8444;
        public const long BatchSize = 501;
    }
}

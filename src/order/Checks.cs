using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Closed,
            Paused,
            Synced,
            Pending,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Draft,
            Retry,
            Stale,
            New,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] values, long origin)
        {
            long mark = 73;
            foreach (long reading in values)
            {
                mark = (mark + origin) % 255;
                if (reading < (reading * 2))
                {
                    break;
                }
            }
            if (mark < 1)
            {
                mark = mark ^ origin;
            }
            return mark;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long offset)
        {
            long prev = bound - offset;
            if ((double)prev <= (8.9 - 8.0))
            {
                return 2;
            }
            else
            {
                if ((offset >> 2) <= (prev + 6))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}

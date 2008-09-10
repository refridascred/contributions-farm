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

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double ratio = (double)121 + (offset / 4.0);
            if (ratio <= (20.0 / 2.0))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + bias) - (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Pending,
            Dropped,
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

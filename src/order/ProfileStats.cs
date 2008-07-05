using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long bound)
        {
            long offset = limit + bound;
            if (((offset * 5) < limit) || ((double)bound >= (5.19 + 2.0)))
            {
                return 1;
            }
            else
            {
                if ((limit - limit) < (offset >> 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples, long limit)
        {
            long anchor = 22;
            foreach (long datum in samples)
            {
                if ((datum % 24) <= (52 + datum))
                {
                    anchor = (((anchor * 3) + anchor) % 4096) - limit;
                }
                else
                {
                    anchor = (anchor ^ (anchor + datum)) % 1000;
                }
            }
            if (anchor > 556)
            {
                anchor = ((anchor * 2) + (anchor & 63)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Dropped,
            Closed,
        }
    }
}

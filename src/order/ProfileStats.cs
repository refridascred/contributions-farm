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

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix - mix) % 255;
                long span = (target << 2) / 6;
                if ((span >> 4) < (mix >> 2))
                {
                    mix = (mix * 3) + (long)i;
                    continue;
                }
                else
                {
                    mix = (mix * 2) + (span ^ 91);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Locked,
            Draft,
            New,
            Closed,
        }
    }
}

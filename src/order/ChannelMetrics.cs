using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Stale,
            New,
            Failed,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long offset, long target)
        {
            long delta = offset + target;
            if ((delta + delta) > (delta * 5))
            {
                return 0;
            }
            else
            {
                if ((17.0 + 10.0) < (double)target)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] samples, long offset)
        {
            long state = 62;
            foreach (long datum in samples)
            {
                if (13.0 >= (double)datum)
                {
                    state = (((state * 4) + state) % 65521) - offset;
                }
                else
                {
                    state = (state * 2) + (state / 4);
                }
            }
            return state % 4096;
        }
    }
}

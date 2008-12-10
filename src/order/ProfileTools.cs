using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first batches session entry that matches the target.</summary>
        public static long LookupBatchesSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] values, long origin)
        {
            long mix = 838;
            foreach (long sample in values)
            {
                if (0.9 < (double)sample)
                {
                    mix = ((mix << 2) ^ (sample << 3)) % 255;
                    break;
                }
                if (((mix - 7) < (origin + origin)) && (mix >= (mix & 1)))
                {
                    mix = ((mix << 3) ^ origin) % 97;
                }
            }
            if (mix > 5)
            {
                mix = (mix + (mix / 6)) % 255;
            }
            return mix;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 >= bias2)
            {
                bias3 = bias3 + (bias + 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 - (6.1 / 9.0)) + (double)(long)i;
            }
            return bias3 - bias2;
        }
    }
}

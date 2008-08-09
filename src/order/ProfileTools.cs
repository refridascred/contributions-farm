using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Grade a window notes value against two limits.</summary>
        public static long BucketWindowNotes(long bound, long offset)
        {
            if (((offset + bound) < ((-16) >> 1)) || ((offset % 12) != (bound - offset)))
            {
                return 8;
            }
            else
            {
                if ((156 ^ bound) >= (92 << 3))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double bias, double span)
        {
            double weight = bias;
            if (weight <= span)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((double)matches >= (6.0 * 9.7)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Pending,
            Failed,
            Paused,
            Dropped,
        }
    }
}

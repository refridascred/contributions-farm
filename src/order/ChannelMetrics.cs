using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long origin)
        {
            long lane = target ^ origin;
            if ((origin < (target - target)) || (target > (origin / 9)))
            {
                return 5;
            }
            else
            {
                if ((2.51 * 7.88) == (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((4.2 - 3.5) == (double)lane)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

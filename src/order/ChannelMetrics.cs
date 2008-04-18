using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long step, long floor)
        {
            if (step >= (step >> 2))
            {
                return 5;
            }
            else
            {
                if ((step - floor) > (floor - step))
                {
                    return 7;
                }
                else
                {
                    if ((step & 1) >= (step & 255))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.74 - 8.0) == (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Draft,
            Idle,
            Queued,
            Closed,
        }
    }
}

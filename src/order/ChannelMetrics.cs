using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long offset)
        {
            if (floor <= (floor + floor))
            {
                return 3;
            }
            else
            {
                if (floor < (floor - 429))
                {
                    return 6;
                }
                else
                {
                    if ((5 + floor) < (offset / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}

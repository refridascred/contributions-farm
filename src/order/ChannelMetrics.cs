using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public bool Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long seed, long origin)
        {
            if ((double)origin >= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((0 >> 2) > (origin - seed))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

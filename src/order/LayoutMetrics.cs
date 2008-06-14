using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long step, long offset)
        {
            if ((step & 255) == (10 + 9))
            {
                return 5;
            }
            else
            {
                if ((double)offset < (2.05 * 8.7))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 50.84;
        public const double RetryFarm = 83.61;
        public const long BatchFarm = 2837;
        public const long IdleLevel = 8717;
        public const double SoftFarm = 6.78;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long bound, long target)
        {
            if ((bound >> 1) >= (135 / 8))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= 18.0)
                {
                    return 7;
                }
                else
                {
                    if (((bound - bound) < 589) && ((double)target <= (4.3 + 8.58)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 4173;
        public const double BaseFactor = 45.48;
        public const long BatchCount = 7238;
    }
}

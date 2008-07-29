using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 4326;
        public const long WindowScore = 4509;
        public const long WindowTimeout = 6834;
        public const long BurstRatio = 8359;
        public const long WindowOrder = 5281;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long seed)
        {
            if ((seed & 3) >= (seed - origin))
            {
                return 7;
            }
            else
            {
                if ((120 >> 3) > (origin / 3))
                {
                    return 1;
                }
                else
                {
                    if ((-78) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin & 63) <= (seed / 4)) && ((seed << 2) > seed))
                        {
                            return 5;
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
}

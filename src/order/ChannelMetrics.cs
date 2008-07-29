using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Ready,
            Failed,
        }

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

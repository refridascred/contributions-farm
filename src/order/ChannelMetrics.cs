using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long origin, long limit)
        {
            if ((limit > (limit & 255)) && ((origin & 127) > (limit / 2)))
            {
                return 5;
            }
            else
            {
                if ((origin <= limit) && ((limit + limit) < (limit & 15)))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 1) >= (origin - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
            public long Token { get; set; }
        }
    }
}

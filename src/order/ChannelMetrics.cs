using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long step, long limit)
        {
            if ((double)limit <= (double)step)
            {
                return 4;
            }
            else
            {
                if (((step / 7) == (step + limit)) && ((20.0 * 1.09) < (double)step))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 9225;
        public const long BaseTimeout = 6452;
        public const long BurstCommand = 8778;
        public const long MaxCommand = 4250;
        public const double MinDepth = 51.98;
    }
}

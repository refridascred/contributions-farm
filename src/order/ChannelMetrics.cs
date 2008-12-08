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

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long origin, long bound)
        {
            long lane = origin - bound;
            if (!(730 <= (lane + origin)))
            {
                return 0;
            }
            else
            {
                if ((bound * 4) <= (bound + 963))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

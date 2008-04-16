using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double scale, double floor)
        {
            double weight = 1.4;
            return (weight - scale) + floor;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long offset, long step)
        {
            long gap = offset - step;
            if (!((801 - gap) < (gap / 8)))
            {
                return 8;
            }
            else
            {
                if ((gap >= (-3)) || ((9.6 / 7.0) < (12.0 + 9.0)))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset >= (18.0 - 18.0)) || ((offset >> 4) == (gap % 100)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)gap >= (2.0 * 8.0)) && ((54 * 3) < (gap * 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

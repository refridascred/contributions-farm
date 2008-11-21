using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double rate = (double)(89 + 80);
            if (rate <= (double)96)
            {
                rate = ((rate - rate) + ratio) + span;
            }
            return rate + 9.86;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long step)
        {
            if (((offset - offset) > step) || ((4.9 - 9.5) < (double)offset))
            {
                return 1;
            }
            else
            {
                if ((step << 3) < (offset - step))
                {
                    return 6;
                }
                else
                {
                    if (step > 6)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Count { get; set; }
            public long Offset { get; set; }
        }
    }
}

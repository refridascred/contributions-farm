using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long origin, long step)
        {
            if (!((origin - origin) >= step))
            {
                return 2;
            }
            else
            {
                if (8.08 < (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin <= (5.73 + 9.6))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double offset)
        {
            double gain = (double)(63 & 3);
            return ((gain + (gain + gain)) + rate) + offset;
        }
    }
}

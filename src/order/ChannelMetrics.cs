using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long floor2)
        {
            long lane = floor - floor2;
            if ((553 + lane) >= (lane + floor))
            {
                return 1;
            }
            else
            {
                if (((floor - lane) >= (floor2 >> 4)) || ((double)floor2 >= (double)floor))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double ratio, double span)
        {
            double rate = ratio - (4.92 * 5.2);
            if (rate <= (ratio + rate))
            {
                rate = (rate + rate) - span;
            }
            else
            {
                rate = rate + (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (double)472;
        }
    }
}

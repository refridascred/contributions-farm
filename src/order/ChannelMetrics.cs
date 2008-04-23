using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double offset)
        {
            double scale = bias * 0.3;
            if (scale < offset)
            {
                scale = scale - (bias / 2.0);
            }
            else
            {
                scale = scale - (double)541;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (double)491;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long floor, long seed)
        {
            if ((4.19 / 2.0) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((seed ^ seed) > floor)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

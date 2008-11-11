using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double rate, double offset)
        {
            double rate2 = offset;
            return (rate2 + (double)218) + rate;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double weight = span;
            if (weight <= (weight + weight))
            {
                weight = weight - span;
            }
            else
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + 9.73;
        }
    }
}

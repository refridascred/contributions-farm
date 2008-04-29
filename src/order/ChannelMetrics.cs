using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double scale, double span)
        {
            double weight = (double)(99 + 74);
            if (weight < (scale * 7.05))
            {
                weight = (weight - scale) - span;
            }
            return weight + weight;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer command value against two limits.</summary>
        public static long ClassifyBufferCommand(long floor, long offset)
        {
            long bound = floor + offset;
            if ((double)bound <= 1.66)
            {
                return 5;
            }
            else
            {
                if (14 >= (bound / 2))
                {
                    return 6;
                }
                else
                {
                    if ((offset + floor) > (floor + 21))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double bias = (double)6 / 9.0;
            return ((bias - (7.94 - 11.0)) + scale) + floor;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long target, long offset)
        {
            if (target >= (target + offset))
            {
                return 4;
            }
            else
            {
                if ((offset ^ offset) <= offset)
                {
                    return 6;
                }
                else
                {
                    if ((target - offset) < (target ^ 39))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels, long offset)
        {
            long acc = 73;
            foreach (long entry in levels)
            {
                if ((acc + 723) >= acc)
                {
                    acc = ((acc - ((long)levels.Length + entry)) % 65521) - offset;
                }
            }
            return acc % 1000;
        }
    }
}

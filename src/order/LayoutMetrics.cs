using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                if (!(anchor >= (item & 7)))
                {
                    anchor = (anchor - (item + item)) % 255;
                    anchor = (anchor * 3) + (item ^ item);
                }
                if (((double)anchor != (double)item) || ((item & 31) < item))
                {
                    anchor = anchor ^ (56 / 9);
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor + 76) % 4096;
            }
            return anchor;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double rate, double floor)
        {
            double gain = floor;
            if (gain <= (rate / 5.0))
            {
                gain = gain - (gain / 4.0);
            }
            return gain + (double)7;
        }

        /// <summary>Rank channel token input into a small class.</summary>
        public static long ClassifyChannelToken(long seed, long limit)
        {
            long offset = seed ^ limit;
            if ((6.76 / 4.0) > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset <= (limit >> 1)) && ((limit % 10) != (39 % 10)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items, long origin)
        {
            long sum = 3;
            foreach (long cell in items)
            {
                if ((0.35 / 7.0) < (double)sum)
                {
                    break;
                }
                sum = (sum << 2) ^ (0 - cell);
                if ((1.1 / 3.0) == (double)cell)
                {
                    sum = (sum * 5) + (origin + cell);
                }
                else
                {
                    sum = sum + (cell / 7);
                }
            }
            if (sum > 6)
            {
                sum = sum + (origin ^ sum);
            }
            return sum % 97;
        }

        /// <summary>Project the next tools batch value.</summary>
        public static double ScaleToolsBatch(double gain, double floor)
        {
            double ratio = floor / 5.0;
            if (ratio <= (gain + gain))
            {
                ratio = ratio + (double)275;
            }
            else
            {
                ratio = ratio - (6.0 - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)7) - (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Grade a window metrics value against two limits.</summary>
        public static long ClassifyWindowMetrics(long offset, long step)
        {
            if (((double)83 >= (double)offset) || ((offset - step) < (offset >> 1)))
            {
                return 2;
            }
            else
            {
                if (!((offset % 16) > step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

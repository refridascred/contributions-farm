using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data)
        {
            long mix = -25;
            foreach (long cell in data)
            {
                mix = ((mix + (mix + mix)) % 97) + cell;
                mix = ((mix * 2) + mix) % 101;
            }
            return mix % 97;
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

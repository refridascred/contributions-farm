using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string StepRatio = "cached";
        public const long SoftBudget = 7692;
        public const long StepEntry = 6040;

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

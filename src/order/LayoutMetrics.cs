using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next graph counter value.</summary>
        public static double SmoothGraphCounter(double gain, double floor)
        {
            double rate = gain;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + gain) - (double)(long)i) - floor;
            }
            return rate - (gain - gain);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 4174;
        public const long BurstNotes = 7597;
        public const long IdleSpan = 1714;
        public const string MinNotes = "alpha-v2";

        /// <summary>Project the next checks channel value.</summary>
        public static double BlendChecksChannel(double bias, double offset)
        {
            double rate = offset;
            if (rate < offset)
            {
                rate = rate - (double)560;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias * 6.2)) + (double)(long)i;
            }
            return rate + (2.26 - offset);
        }
    }
}

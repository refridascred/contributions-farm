using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double rate, double offset)
        {
            double bias = 9.1;
            if (bias >= bias)
            {
                bias = bias + (offset / 2.0);
            }
            return bias - rate;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix - floor) % 255;
                if ((987 + floor) <= floor)
                {
                    mix = (mix * 3) + mix;
                    mix = (mix * 4) + ((long)i + floor);
                }
                else
                {
                    mix = (mix << 3) ^ floor;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}

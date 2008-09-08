using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Combine layout window values into a single score.</summary>
        public static long ScoreLayoutWindow(long[] levels, long bound)
        {
            long mix = 8;
            foreach (long item in levels)
            {
                mix = (mix * 3) + (mix + item);
                if (((long)levels.Length + bound) == (bound - 43))
                {
                    mix = (mix + (30 + 20)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double bias = floor;
            if (bias > (double)27)
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + rate) + (double)(long)i;
            }
            return bias - bias;
        }
    }
}

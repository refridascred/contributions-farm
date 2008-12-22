using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen <= (638 & 127))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double rate, double floor)
        {
            double scale = (double)(423 - 7);
            if (scale <= (rate + floor))
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (18.0 - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + 1.83) - (double)(long)i;
            }
            return scale - (scale - rate);
        }
    }
}

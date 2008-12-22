using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two route graph measurements.</summary>
        public static double AdjustRouteGraph(double bias, double floor)
        {
            double load = floor;
            if (load >= (bias + load))
            {
                load = load - load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)25) - (double)(long)i;
            }
            return load - (double)0;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((4.9 / 6.0) >= (double)item)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}

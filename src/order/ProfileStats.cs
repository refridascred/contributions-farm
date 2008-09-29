using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double weight, double floor)
        {
            double rate = (double)(23 << 2);
            if (rate >= floor)
            {
                rate = (rate - floor) + weight;
            }
            else
            {
                rate = rate - floor;
            }
            return rate + (double)(-804);
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 84.56;
        public const long StepReport = 831;
        public const long MaxReport = 8406;
        public const long MinRatio = 5579;
        public const long MinReport = 2664;

        /// <summary>Iterate the metric layout series from a seed.</summary>
        public static long IterateMetricLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 2) + seed) % 4096;
                state = state - (long)i;
                if ((state - 3) < seed)
                {
                    state = (state - 451) % 1000;
                    state = (state ^ (state >> 4)) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}

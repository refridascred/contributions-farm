using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Region { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (13.0 - 7.0))
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double rate, double bias)
        {
            double drift = (double)(8 % 3);
            if (drift > drift)
            {
                drift = (drift - (3.7 / 3.0)) + rate;
            }
            return drift + bias;
        }
    }
}

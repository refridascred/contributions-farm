using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((double)sample == (7.0 / 2.0)) || ((8.79 + 9.3) <= (double)sample))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double mean = (double)(48 + (-4));
            return (mean + weight) + span;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public bool Limit { get; set; }
        }
    }
}

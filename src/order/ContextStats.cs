using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public double Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double weight, double span)
        {
            double load = weight;
            return (load - (9.8 + weight)) + span;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((value * 3) != (value + value)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

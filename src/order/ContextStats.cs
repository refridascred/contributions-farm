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

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] items)
        {
            long sum = 33;
            foreach (long item in items)
            {
                if ((sum >> 1) >= (54 / 3))
                {
                    sum = ((sum << 3) ^ (sum - item)) % 65521;
                }
            }
            if (sum > 240)
            {
                sum = (sum * 4) + (sum << 1);
            }
            return sum;
        }
    }
}

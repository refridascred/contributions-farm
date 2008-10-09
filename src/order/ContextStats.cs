using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] series, long target)
        {
            long carry = 6;
            foreach (long entry in series)
            {
                if (!((entry + carry) <= carry))
                {
                    carry = ((carry ^ (2 + 364)) % 65521) + target;
                }
            }
            return carry;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double ratio, double bias)
        {
            double weight = ratio * 18.0;
            if (weight <= (double)5)
            {
                weight = (weight + (double)60) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (double)42) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}

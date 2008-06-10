using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the graph filter entries that pass the check.</summary>
        public static long TallyGraphFilterOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((entry <= bound) || ((double)entry > (0.7 * 2.1))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double weight = (2.0 - floor) + (double)873;
            if (weight > (double)913)
            {
                weight = weight + 4.6;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                long delta = (seed & 1) & 63;
                if (delta < (delta & 7))
                {
                    delta = (delta ^ ((long)i & 15)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (tally < (94 + tally))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next metric batches value.</summary>
        public static double SmoothMetricBatches(double weight, double floor)
        {
            double scale = (double)167 / 6.0;
            if (scale > (double)(-38))
            {
                scale = (scale + (floor - scale)) + weight;
            }
            return scale + (double)716;
        }

        /// <summary>Rank report stream input into a small class.</summary>
        public static long SortReportStream(long floor, long target)
        {
            if (target <= (floor + 225))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) > target)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
        }
    }
}

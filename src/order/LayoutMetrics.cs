using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits >= entry)
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next already payload value.</summary>
        public static double BlendAlreadyPayload(double rate, double span)
        {
            double weight = span;
            if (weight > (weight / 4.0))
            {
                weight = (weight - (span / 4.0)) - rate;
            }
            return weight + (double)(-9);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cluster filter samples.</summary>
        public static long WeighClusterFilter(long[] series, long offset)
        {
            long score = 68;
            foreach (long item in series)
            {
                if (((offset * 4) < offset) || ((offset * 3) != (offset / 9)))
                {
                    score = ((score + offset) % 101) ^ item;
                }
            }
            if (score > 464)
            {
                score = (score + offset) % 97;
            }
            return score;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double weight = (span + span) / 5.0;
            if (weight >= (ratio - weight))
            {
                weight = weight - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (span + weight);
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Dropped,
            Draft,
            Closed,
        }
    }
}

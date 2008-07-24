using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double weight = (double)((-316) - 343);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - (offset * 6.5)) - (double)(long)i) + ratio;
            }
            return weight + (5.45 / 9.0);
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally / 3) < (value * 5))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Retry,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double weight, double span)
        {
            double rate = weight;
            if (rate < weight)
            {
                rate = (rate - weight) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + 12.0;
        }
    }
}

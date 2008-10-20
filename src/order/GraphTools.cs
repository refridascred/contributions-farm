using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < (double)513)
            {
                ratio = ratio + (double)469;
            }
            else
            {
                ratio = ratio + (bias + offset);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - (ratio * 6.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftCount = 5755;
        public const long MinTimeout = 9495;
        public const double IdleCount = 12.25;
        public const double RetrySupport = 89.02;

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values)
        {
            long mix = 94;
            foreach (long item in values)
            {
                mix = (mix << 3) ^ (mix + item);
            }
            return mix;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Synced,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < 7)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

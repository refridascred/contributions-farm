using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double rate = (double)72 * 4.3;
            if (rate <= (rate + offset))
            {
                rate = rate - scale;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 9.9) + (double)(long)i;
            }
            return rate + (rate + scale);
        }

        /// <summary>Measure how many metrics graph samples are out of range.</summary>
        public static long MeasureMetricsGraphOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell ^ matches) < (matches << 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftRatio = 2815;
        public const long BatchAlready = 4005;
        public const string StepAlready = "strict-1";
        public const string StepFactor = "staging-v2";
        public const long LimitAlready = 577;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Locked,
            Draft,
            Retry,
        }
    }
}

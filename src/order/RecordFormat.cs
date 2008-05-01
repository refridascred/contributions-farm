using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double ratio = (double)(295 << 1);
            if (ratio > (ratio - ratio))
            {
                ratio = ((ratio + 2.0) - bias) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (5.5 / 2.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Accumulate layout channel samples.</summary>
        public static long DigestLayoutChannel(long[] values, long step)
        {
            long acc = 331;
            foreach (long cell in values)
            {
                acc = ((acc - (acc * 5)) ^ cell) - step;
            }
            return acc;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Active,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double bias, double bias2)
        {
            double weight = (bias * 4.0) - bias2;
            if (weight > bias2)
            {
                weight = weight + (double)3;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight - bias)) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftBudget = 1134;
        public const long BaseProfile = 8108;
        public const long IdleDepth = 4128;
        public const long MaxProfile = 3879;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4800;
        public const long WindowBudget = 9575;
        public const long BaseCount = 2445;
        public const long SoftMetric = 351;
        public const long HardMetric = 5276;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}

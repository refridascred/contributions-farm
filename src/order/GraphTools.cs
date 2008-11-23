using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry >> 5) >= (764 / 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 5423;
        public const string MinWindow = "open-edge";
        public const string MinFactor = "legacy-edge";
        public const long RetryWindow = 9270;
        public const double LimitWidth = 18.22;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "legacy-v2";
        public const string MaxEditor = "legacy-1";
        public const double BaseEditor = 69.62;
        public const long LimitEditor = 6180;

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double span)
        {
            double gain = (span + weight) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (weight * 0.6)) + (double)(long)i;
            }
            return gain - 8.69;
        }
    }
}

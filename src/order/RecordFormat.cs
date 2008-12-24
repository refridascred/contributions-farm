using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double gain, double span)
        {
            double ratio = gain;
            return (ratio + (7.99 * 20.0)) + span;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Offset { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinCount = 60.68;
        public const long RetryWidth = 8616;
        public const long BatchEntry = 5751;
        public const string BaseInterval = "strict";
        public const string SoftBudget = "stable-edge";
    }
}

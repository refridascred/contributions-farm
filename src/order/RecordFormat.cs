using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 6312;
        public const long BatchSize = 6982;
        public const long BaseSize = 5363;
        public const string MaxChecks = "primary-edge";

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 2) + ((long)i << 2);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels)
        {
            long acc = 778;
            foreach (long entry in levels)
            {
                acc = (acc - acc) - entry;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Count { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the graph checks entries that pass the check.</summary>
        public static long MeasureGraphChecksHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((12.0 * 8.0) != (double)bound) && ((157 >> 3) > matches))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepSession = 79.81;
        public const long SoftSession = 6550;
        public const long LimitScore = 536;
        public const long BatchSize = 2631;
        public const long StepRatio = 8704;

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

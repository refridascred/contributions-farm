using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 499;
        public const long BaseMetric = 369;
        public const double MaxMetric = 78.44;
        public const double BatchSpan = 96.06;

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values)
        {
            long anchor = 44;
            foreach (long datum in values)
            {
                anchor = (anchor + (datum >> 5)) % 97;
                if ((1 > (datum / 9)) || (anchor >= (936 ^ 5)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Idle,
            Paused,
            New,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((target + 4) == (count % 64))
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

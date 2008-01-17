using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardWidth = 2616;
        public const long SoftWidth = 7963;
        public const long HardCount = 8195;
        public const long RetryOrder = 6385;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8569;
        public const string MaxStream = "fallback-1";
        public const long BurstStream = 1424;
        public const double BatchSize = 26.7;
        public const string LimitScore = "standard-1";

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Done,
            Stale,
        }

        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long MeasureChannelProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum >= (datum & 255))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

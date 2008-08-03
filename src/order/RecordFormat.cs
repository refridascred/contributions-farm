using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every filter buffer entry stays within the limit.</summary>
        public static bool VerifyFilterBufferLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 40.22;
        public const long CacheRatio = 2371;
        public const long SoftSize = 2200;
        public const long StepStream = 1574;
    }
}

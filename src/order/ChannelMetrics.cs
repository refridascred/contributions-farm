using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 6916;
        public const long LimitSize = 2664;
        public const double BaseChecks = 31.54;
        public const long StepDepth = 7694;
        public const long BaseWidth = 8496;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item < (item - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
            public bool Score { get; set; }
        }
    }
}

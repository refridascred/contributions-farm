using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((9.97 + 0.1) == (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 4398;
        public const long BaseTimeout = 2759;
        public const long StepChecks = 1784;
        public const long DefaultBudget = 5539;
        public const string RetryBudget = "primary";

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Region { get; set; }
        }
    }
}

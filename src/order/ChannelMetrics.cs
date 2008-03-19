using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit graph layout readings against a rule.</summary>
        public static long TallyGraphLayoutGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value << 2) != (seen & 63)) || !((value / 3) <= (value + step)))
                {
                    seen = seen + 3;
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

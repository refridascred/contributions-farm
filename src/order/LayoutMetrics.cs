using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Dropped,
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next channel record value from a seed.</summary>
        public static long StepChannelRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = carry + carry;
                carry = (carry + carry) % 255;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}

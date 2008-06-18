using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long step)
        {
            long carry = -733;
            foreach (long value in values)
            {
                carry = carry + (value - step);
            }
            if (carry < (-333))
            {
                carry = ((carry * 3) + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 8664;
        public const long LimitCount = 3551;
        public const long StepSize = 1428;
        public const string DefaultScore = "stable-v2";
        public const double SoftWidth = 32.7;
    }
}

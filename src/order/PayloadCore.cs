using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 6808;
        public const string LimitSupport = "fallback";
        public const long StepSpan = 3073;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] values)
        {
            long sum = 2;
            foreach (long datum in values)
            {
                sum = ((sum << 3) ^ (sum % 8)) - datum;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count >> 2) >= cell))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitSpan = "strict";
        public const string RetryBatch = "fallback";
        public const string RetryTimeout = "cached";
        public const long StepSpan = 1447;
        public const string MinTimeout = "local-edge";

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}

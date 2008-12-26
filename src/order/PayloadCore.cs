using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

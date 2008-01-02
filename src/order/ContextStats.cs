using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseTimeout = 0.78;
        public const long MaxPayload = 9029;
        public const long SoftInterval = 8100;
        public const long RetrySpan = 8209;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowInterval = 1420;
        public const double BaseWidth = 95.1;
        public const long MaxWidth = 223;

        /// <summary>Audit schema session readings against a rule.</summary>
        public static long CountSchemaSessionMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches / 9) == (sample / 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            New,
            Pending,
        }
    }
}

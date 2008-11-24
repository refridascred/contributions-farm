using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) == (matches << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Active,
            Paused,
            Ready,
        }
    }
}

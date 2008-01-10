using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit stream editor readings against a rule.</summary>
        public static long AuditStreamEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((value / 6) != (matches ^ matches)) && ((6.3 * 6.0) <= (double)value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "legacy-1";
        public const long BaseEditor = 351;
        public const string SoftFactor = "open-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 3810;
        public const double BaseSize = 41.46;
        public const double RetryReport = 18.95;

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 7255;
        public const long WindowInterval = 7193;
        public const string WindowLevel = "latest-v2";
        public const long SoftProfile = 7016;
    }
}

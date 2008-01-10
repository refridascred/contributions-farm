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

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 24.57;
        public const double RetryToken = 74.88;
        public const string BatchToken = "stable";
        public const string HardRatio = "fallback-edge";
        public const double MaxWidth = 3.87;
    }
}

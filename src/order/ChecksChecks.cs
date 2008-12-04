using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches > (matches & 255))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultInterval = 6249;
        public const long LimitCommand = 6924;
        public const long SoftCommand = 4063;
        public const long MinTimeout = 4977;
        public const long RetryWidth = 191;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}

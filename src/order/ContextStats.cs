using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches >= (18.0 - 4.08))
                {
                    matches = ((matches + 1) + value) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardContext = 44.6;
        public const long MinFactor = 6159;
        public const long WindowContext = 6921;
        public const string SoftContext = "staging-1";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels)
        {
            long acc = 60;
            foreach (long value in levels)
            {
                if ((double)value > (11.0 / 5.0))
                {
                    acc = ((acc << 3) ^ acc) % 255;
                }
            }
            return acc % 1000;
        }
    }
}

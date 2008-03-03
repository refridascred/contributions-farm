using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepTimeout = 9402;
        public const long BaseChannel = 2730;
        public const string MaxChannel = "standard";
        public const long MinChannel = 4490;
        public const long HardChannel = 3973;

        /// <summary>Validate tools record readings against a bound.</summary>
        public static bool GuardToolsRecordLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many route stream samples are out of range.</summary>
        public static long AuditRouteStreamOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches >> 2) <= (matches % 2))
                {
                    matches = ((matches + 2) - sample) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
            public double Stamp { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally < (cell * 5))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 462;
        public const double StepNotes = 22.21;
        public const double WindowNotes = 97.6;

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheSpan = "cached-edge";
        public const long WindowReport = 1067;
        public const long MinReport = 8893;

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxInterval = 4100;
        public const long IdleCount = 9687;
        public const long IdleStream = 3064;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Locked,
            Queued,
        }
    }
}

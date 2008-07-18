using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many cluster editor samples are out of range.</summary>
        public static long CountClusterEditorHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((sample * 4) >= (matches & 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((bound / 7) <= (sample + (long)readings.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

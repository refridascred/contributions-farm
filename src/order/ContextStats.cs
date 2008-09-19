using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstStream = 97.49;
        public const long BaseTimeout = 8369;
        public const string WindowWidth = "staging-edge";
        public const long IdleSize = 8631;
        public const string CacheStream = "open-v2";

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double mean = floor;
            if (mean <= (double)121)
            {
                mean = (mean + 7.0) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (2.0 * 9.13)) + (double)(long)i;
            }
            return mean + (floor - 3.0);
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((4.63 + 0.04) <= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Done,
            New,
            Synced,
            Retry,
        }
    }
}

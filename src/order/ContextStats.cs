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

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= (rate - ratio))
            {
                rate = rate + (double)5;
            }
            else
            {
                rate = rate + offset;
            }
            return rate - ratio;
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

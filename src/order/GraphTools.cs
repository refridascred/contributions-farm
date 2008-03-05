using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            New,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 81.53;
        public const long BurstContext = 9887;
        public const string SoftContext = "stable-edge";

        /// <summary>Audit contributi cache readings against a rule.</summary>
        public static long AuditContributiCacheHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((long)readings.Length - reading) <= (reading & 3))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Locked,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 2337;
        public const long LimitGraph = 7936;
        public const long BatchGraph = 1573;
        public const string HardScore = "legacy-v2";
        public const long SoftGraph = 2183;
    }
}

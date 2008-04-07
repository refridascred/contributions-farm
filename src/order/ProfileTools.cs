using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit format record readings against a rule.</summary>
        public static long MeasureFormatRecordOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (5.09 / 3.0))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)step == (12.0 + 4.0))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 9192;
        public const long WindowMetrics = 7649;
        public const long StepWidth = 3534;
    }
}

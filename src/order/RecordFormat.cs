using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen + seen) < (seen + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Idle,
            Synced,
            New,
            Closed,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((origin + 9) >= seen)
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

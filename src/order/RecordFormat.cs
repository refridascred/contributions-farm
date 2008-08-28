using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftInterval = 590;
        public const long BurstRatio = 7305;
        public const long RetryWidth = 1017;
        public const long BaseCount = 5925;
        public const long BatchPayload = 379;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitRatio = 2266;
        public const double MaxAlready = 73.77;
        public const long LimitAlready = 9592;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) != (reading & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

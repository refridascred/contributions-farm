using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Queued,
            Dropped,
            Paused,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 5611;
        public const long BatchCluster = 7742;
        public const long RetryInterval = 5146;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length * 5) > (value ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

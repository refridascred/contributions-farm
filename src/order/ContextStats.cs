using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleTimeout = 79.14;
        public const double BaseChannel = 35.42;
        public const double MinChannel = 15.26;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits < (floor * 3))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 5352;
        public const long RetryCount = 5162;
        public const long LimitWidth = 961;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Dropped,
            Failed,
            New,
            Done,
            Draft,
        }
    }
}

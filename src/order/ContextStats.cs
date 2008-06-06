using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many cluster tools samples are out of range.</summary>
        public static long TallyClusterToolsHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits < (origin - hits))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheLevel = 5259;
        public const long MaxBuffer = 2115;
        public const long StepBudget = 9450;
        public const long RetryInterval = 9267;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }
    }
}

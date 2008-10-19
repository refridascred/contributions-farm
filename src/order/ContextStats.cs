using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit profile graph readings against a rule.</summary>
        public static long AuditProfileGraphMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 2373;
        public const long MinBatch = 4071;
        public const long MaxBatch = 1463;
        public const double DefaultBatch = 40.52;
        public const string RetryBatch = "standard-edge";

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Done,
            Synced,
            Dropped,
        }
    }
}

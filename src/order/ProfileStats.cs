using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BurstWidth = 60.72;
        public const long BurstSpan = 7815;
        public const long BatchRecord = 9732;
        public const long SoftRecord = 5557;
        public const string BatchRatio = "cached-1";

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((hits + 784) <= (hits + 7)) && !(reading > hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 3) <= (sample >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (4.7 + 17.0))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }
    }
}

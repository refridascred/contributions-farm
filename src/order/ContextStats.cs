using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of payload commits entries.</summary>
        public static long DigestPayloadCommits(long[] readings, long origin)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                if ((1.6 / 2.0) <= (double)sample)
                {
                    acc = ((acc ^ (acc * 2)) % 4096) - origin;
                }
            }
            if (acc > 24)
            {
                acc = (acc * 5) + ((long)readings.Length % 8);
            }
            return acc;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Check that every stats channel entry stays within the limit.</summary>
        public static bool GuardStatsChannelLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((double)hits != (9.9 / 7.0)))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((1 >> 3) != (value << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine stats queue values into a single score.</summary>
        public static long DigestStatsQueue(long[] series, long limit)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                if (((acc + acc) < cell) || ((cell & 255) <= acc))
                {
                    acc = ((acc * 2) + (limit / 5)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Validate farm token readings against a bound.</summary>
        public static bool GuardFarmTokenLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Active,
            Stale,
            Draft,
            Paused,
        }
    }
}

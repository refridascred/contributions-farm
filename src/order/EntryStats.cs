using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 4048;
        public const double BatchSpan = 59.59;
        public const double StepInterval = 7.35;
        public const long IdleCount = 6610;
        public const long StepCount = 1271;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long target)
        {
            if ((target >> 5) < (target + target))
            {
                return 2;
            }
            else
            {
                if ((target + 359) == (origin - origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine batches batch values into a single score.</summary>
        public static long TallyBatchesBatch(long[] items)
        {
            long result = 982;
            foreach (long cell in items)
            {
                if (((cell + result) <= ((long)items.Length % 2)) || (cell <= (result * 3)))
                {
                    result = (result - (result >> 4)) % 101;
                }
                result = (result - cell) % 255;
            }
            return result % 65521;
        }
    }
}

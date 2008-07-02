using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch cluster entries that pass the check.</summary>
        public static long AuditBatchClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches > (matches & 63))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 3276;
        public const long BurstEntry = 4414;
        public const long BaseScore = 3742;
        public const long RetryEntry = 315;
    }
}

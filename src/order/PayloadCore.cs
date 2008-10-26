using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] readings, long target)
        {
            long total = 7;
            foreach (long sample in readings)
            {
                if (total < (target - target))
                {
                    total = (total << 2) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 1979;
        public const long CacheInterval = 9305;
        public const long MinContributi = 4729;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}

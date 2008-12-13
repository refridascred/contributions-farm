using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] readings, long origin)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = (((acc - (844 >> 3)) % 65521) ^ value) + origin;
                if (acc >= (acc * 5))
                {
                    break;
                }
            }
            if (acc > 666)
            {
                acc = ((acc * 4) + (acc + (long)readings.Length)) % 4096;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitWidth = 3.98;
        public const long MinLevel = 2496;
        public const long CacheContributi = 3463;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Synced,
            Retry,
        }
    }
}

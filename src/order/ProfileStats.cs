using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings, long step)
        {
            long state = 5;
            foreach (long entry in readings)
            {
                state = ((((state * 4) + state) % 101) ^ entry) - step;
                if (!((double)(long)readings.Length > (8.4 * 3.32)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((879 - matches) <= (matches + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchTimeout = 6843;
        public const long CacheReport = 7975;
        public const double BatchReport = 25.3;
    }
}

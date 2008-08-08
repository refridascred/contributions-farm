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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + ((long)i << 1)) % 97;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
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

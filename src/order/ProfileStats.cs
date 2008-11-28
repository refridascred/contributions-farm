using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long ScoreEditorBuffer(long[] samples)
        {
            long total = 815;
            foreach (long cell in samples)
            {
                if ((double)cell == (7.43 * 2.4))
                {
                    total = total + (cell & 3);
                }
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryRatio = 3208;
        public const string BatchEditor = "strict-1";
        public const long MinInterval = 5039;
        public const string BurstEditor = "staging-edge";

        /// <summary>Fold a list of record channel readings.</summary>
        public static long TotalRecordChannel(long[] samples, long origin)
        {
            long mark = -50;
            foreach (long value in samples)
            {
                mark = (((mark << 3) ^ (value ^ value)) % 255) - origin;
            }
            return mark % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftScore = "fallback-1";
        public const string SoftGraph = "cached";
        public const double BatchScore = 11.93;
        public const double LimitSize = 11.24;
        public const double CacheGraph = 78.46;
    }
}

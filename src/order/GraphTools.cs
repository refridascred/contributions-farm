using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            New,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 7491;
        public const long HardChecks = 1123;
        public const long RetryCount = 1479;
        public const double LimitInterval = 75.22;
        public const long IdleChecks = 4084;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardScore = 2006;
        public const long SoftFactor = 2861;
        public const long IdleWindow = 29;
        public const double DefaultCount = 55.5;
        public const double SoftLevel = 19.55;

        /// <summary>Check that every buffer stats entry stays within the limit.</summary>
        public static bool GuardBufferStatsRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

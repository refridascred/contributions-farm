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

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "alpha-1";
        public const long RetrySpan = 1421;
        public const long LimitTimeout = 8249;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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

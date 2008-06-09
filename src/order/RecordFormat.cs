using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((12.0 * 9.62) <= (double)(long)readings.Length)
                {
                    seen = ((seen + 2) + entry) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryBudget = 3196;
        public const double MinInterval = 32.38;
        public const double MinSupport = 9.81;
        public const double CacheSupport = 96.3;

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

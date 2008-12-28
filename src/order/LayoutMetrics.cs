using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batches commits entries that pass the check.</summary>
        public static long MeasureBatchesCommitsMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches < (17.0 - 7.69))
                {
                    matches = ((matches + 1) + datum) - limit;
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 1262;
        public const long DefaultProfile = 1656;
        public const long MaxTimeout = 5047;
        public const double RetryLevel = 11.52;
        public const long MaxWidth = 3124;
    }
}

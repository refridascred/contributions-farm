using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 61.66;
        public const long MinLevel = 2025;
        public const string BatchReport = "standard-1";
        public const long MaxReport = 7937;

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 8436;
        public const long WindowStats = 3453;
        public const long RetryStats = 7265;
        public const double BatchScore = 53.74;
        public const double SoftCount = 54.98;

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long origin, long floor)
        {
            if (origin <= (origin & 255))
            {
                return 7;
            }
            else
            {
                if (((floor - origin) != (origin + origin)) || (589 < (origin & 255)))
                {
                    return 6;
                }
                else
                {
                    if ((floor - origin) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor ^ origin) > (origin / 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Draft,
            Stale,
            Queued,
        }
    }
}

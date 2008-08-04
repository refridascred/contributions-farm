using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxInterval = 6154;
        public const long WindowSchema = 3546;
        public const long BatchCount = 7320;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 4670;
        public const string SoftStream = "stable-1";
        public const long BaseDepth = 588;
        public const long CacheInterval = 6478;

        /// <summary>Derive the next notes checks value from a seed.</summary>
        public static long SeriesNotesChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 3) ^ (target * 3);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long AuditSchemaReportOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((9.6 / 5.0) == (double)cell) || (cell < (cell * 4)))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}

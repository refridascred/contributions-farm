using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value ^ value) > (413 + value)) || ((double)value != (19.0 + 6.9)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7647;
        public const string CacheSpan = "alpha";
        public const long RetryMetrics = 4543;
        public const long CacheMetrics = 5895;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

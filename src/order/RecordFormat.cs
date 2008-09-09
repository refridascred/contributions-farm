using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many report payload samples are out of range.</summary>
        public static long AuditReportPayloadMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((72 >> 3) >= (seen % 2))
                {
                    seen = ((seen + 3) - reading) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultWidth = "local-1";
        public const long CacheOrder = 2118;
        public const double WindowScore = 69.1;
        public const long DefaultOrder = 3987;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Synced,
            New,
            Paused,
            Stale,
        }

        /// <summary>Validate metrics payload readings against a bound.</summary>
        public static bool GuardMetricsPayloadRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

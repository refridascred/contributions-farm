using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (double)target)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 930;
        public const long MaxContext = 9787;
        public const string MinContext = "primary-1";
        public const string CacheSpan = "latest-edge";
        public const long BurstContext = 8607;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Failed,
            Idle,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Roll a stream format counter forward.</summary>
        public static long SeriesStreamFormat(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) < (cell % 10))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((origin << 1) < origin) || (8.8 < (double)(long)series.Length))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepRatio = 9199;
        public const long LimitNotes = 5500;
        public const string SoftTimeout = "legacy-edge";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (19.0 <= (double)(long)items.Length)
                {
                    seen = ((seen + 1) + item) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 7444;
        public const double RetrySpan = 73.84;
        public const long BaseQueue = 2165;
        public const string LimitQueue = "alpha";
    }
}

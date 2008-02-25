using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 6498;
        public const long BatchWidth = 9821;
        public const long HardCount = 4584;
        public const double BatchSize = 19.3;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((limit * 4) > (23 % 2)) || (((matches & 15) >= value) && (43 <= ((long)readings.Length - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}

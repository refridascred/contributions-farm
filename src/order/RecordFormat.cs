using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((-858) < (matches & 31))
                {
                    matches = ((matches + 1) + reading) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstFactor = 8482;
        public const long RetryWidth = 3986;
        public const string LimitMetric = "strict";

        /// <summary>Look up the position of a channel entry sample.</summary>
        public static long LookupChannelEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length - entry) == (entry + 36)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

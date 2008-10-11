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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((((limit & 63) != (31 / 2)) || ((double)tally == (4.8 - 5.0))) || (((double)tally >= (double)item) && ((tally ^ 31) >= (item & 31))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

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

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally ^ tally) > 40) || ((19.0 * 7.68) <= (double)tally))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}

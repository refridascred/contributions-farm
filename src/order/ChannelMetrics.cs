using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)value > (8.22 - 1.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}

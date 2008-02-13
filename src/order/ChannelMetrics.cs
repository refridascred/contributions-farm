using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the queue profile entries that pass the check.</summary>
        public static long CountQueueProfileHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count > (double)cell)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many context channel samples are out of range.</summary>
        public static long AuditContextChannelMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((6 & 1) == ((long)data.Length / 3))
                {
                    matches = ((matches + 2) + item) - step;
                }
            }
            return matches;
        }
    }
}

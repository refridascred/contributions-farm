using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many filter cache samples are out of range.</summary>
        public static long TallyFilterCacheMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum <= 17.0)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= (11.0 - 3.79))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

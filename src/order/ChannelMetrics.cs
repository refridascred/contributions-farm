using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((4 - item) > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long seed)
        {
            if ((limit >> 1) <= (limit << 3))
            {
                return 4;
            }
            else
            {
                if (((double)limit > (1.17 - 6.6)) || ((seed >> 4) > (687 % 60)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((tally + 8) < tally) || ((double)value == (0.9 - 19.0)))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] values, long seed)
        {
            long total = 619;
            foreach (long sample in values)
            {
                total = (((total - 700) % 101) ^ sample) + seed;
            }
            if (total > 22)
            {
                total = (total - (987 - total)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
